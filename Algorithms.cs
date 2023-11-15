
namespace ADP
{
    public static class Algorithms
    {
        public static void DynamicArray()
        {
            Console.WriteLine("TESTEN -> Dynamic Array");
            Console.WriteLine("##############################");
            var al = new ArrayList<string>(10);
            Console.WriteLine("ADD");
            al.Add("Maandag");
            al.Add("Dinsdag");
            al.Add("Donderdag");
            showArrayContent(al);

            Console.WriteLine("SET");
            al.Set("Woensdag", 2);
            showArrayContent(al);

            Console.WriteLine("REMOVE (by index)");
            al.Remove(1);
            showArrayContent(al);

            Console.WriteLine("SIZE: {0}", al.Size);
        }

        private static void showArrayContent(ArrayList<string> al) {
              for (var i = 0; i < al.Size; ++i)
            {
                Console.WriteLine(al[i]);
            }
            //Console.WriteLine("Size: {0}", al.Size);
            Console.WriteLine("---");       
        }
    }
}