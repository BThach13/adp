namespace ADP;

class Program
{
    static void Main(string[] args)
    {
        Algorithms.DynamicArray();

        //--------------------------------------------------------------------------------------------------
        string filePath = @"C:\_UserData\GitHub\Repos\adp\testFiles\lijst_aflopend_2.json";
        string currentPath = Directory.GetCurrentDirectory();
        Console.WriteLine("Current Path: " + currentPath);

        // Ensure the file exists
        if (File.Exists(filePath))
        {
            // Open the file with a StreamReader
            using (StreamReader reader = new StreamReader(filePath))
            {
                // Read the entire file
                string content = reader.ReadToEnd();
                Console.WriteLine("File Content:");
                Console.WriteLine(content);
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}