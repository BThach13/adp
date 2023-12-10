using System.Net;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace ADP
{
    public class TestCases
    {
        private JsonNode? _jsonNodes;
        public TestCases()
        {
            ReadFile();
        }
        private void ReadFile()
        {
            string url = "https://han-aim.gitlab.io/dt-sd-asd/materials/ADP/bron/dataset_sorteren.json";
            string jsonString = string.Empty;
            // Ensure the file exists
            try
            {
                using (StreamReader reader = new StreamReader(WebRequest.Create(url).GetResponse().GetResponseStream()))
                {
                    jsonString = reader.ReadToEnd();
                    _jsonNodes = JsonNode.Parse(jsonString)!;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public string[] getNodeNames()
        {
            string[] names = new string[20];
            try
            {
                names = _jsonNodes.AsObject().Select(property => property.Key).ToArray();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return names;          
        }

        public T[]? Get_List<T>(string listName)
        {
            try
            {
                JsonNode jsonNode = _jsonNodes![listName]!;
                string list = jsonNode.ToJsonString();
                T[]? jsonArray = JsonSerializer.Deserialize<T[]>(list);
                if (jsonArray != null)
                    return jsonArray;
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("List not found!");
            }
            return null;
        }
    }
}