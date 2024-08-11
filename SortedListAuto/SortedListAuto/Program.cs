using System.Collections;

namespace SortedListAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();

           
            sl.Add(3, "Three");
            sl.Add(1, "One");
            sl.Add(2, "Two");

            
            foreach (DictionaryEntry entry in sl)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }

            sl.RemoveAt(0);
            sl.ContainsKey(3);
            sl.ContainsValue("Three");
            // Output will be sorted by key:
            // Key: 1, Value: One
            // Key: 2, Value: Two
            // Key: 3, Value: Three
        }
    }
}
