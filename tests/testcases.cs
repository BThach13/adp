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
            string filePath = @"C:\_UserData\GitHub\Repos\adp\tests\dataset_sorteren.json";
            string jsonString = string.Empty;
            // Ensure the file exists
            if (File.Exists(filePath))
            {
                // Open the file with a StreamReader
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // Read the entire file
                    jsonString = reader.ReadToEnd();
                    // Create a JsonNode DOM from a JSON string.
                    _jsonNodes = JsonNode.Parse(jsonString)!;
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }

        public T[] Get_List<T>(string listName)
        {
             // Get value from a JsonNode.
            JsonNode jsonNode = _jsonNodes![listName]!;
            string list = jsonNode.ToJsonString();
            T[]? jsonArray = JsonSerializer.Deserialize<T[]>(list);
            if (jsonArray != null)
                return jsonArray;
            else
                return null;
        }

        public int[] List_Desc()
        {
             // Get value from a JsonNode.
            JsonNode lijst_aflopend_2 = _jsonNodes!["lijst_aflopend_2"]!;
            string list = lijst_aflopend_2.ToJsonString();
            int[]? jsonArray = JsonSerializer.Deserialize<int[]>(list);
            if (jsonArray != null)
                return jsonArray;
            else
                return null;
        }
        public float[] List_Float()
        {
             // Get value from a JsonNode.
            JsonNode lijst_float_8001 = _jsonNodes!["lijst_float_8001"]!;
            string list = lijst_float_8001.ToJsonString();
            float[]? jsonArray = JsonSerializer.Deserialize<float[]>(list);
            if (jsonArray != null)
                return jsonArray;
            else
                return null;
        }
    }
}