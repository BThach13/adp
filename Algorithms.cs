
namespace ADP
{
    public static class Algorithms
    {
        public static void dynamicRows()
        {
            List<string> dynamicRows = new List<string>();

            dynamicRows.Add("PSV");
            dynamicRows.Add("Feyenoord");
            dynamicRows.Add("Ajax");

            // Accessing dynamic rows
            foreach (var row in dynamicRows)
            {
                Console.WriteLine($"Club: {row}");
            }
        }
    }
}