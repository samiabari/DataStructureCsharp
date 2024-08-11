namespace SortedDictionaryAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();

           
            sortedDictionary.Add(3, "Three");
            sortedDictionary.Add(1, "One");
            sortedDictionary.Add(2, "Two");

            foreach (var entry in sortedDictionary)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
            // Output will be sorted by key:
            // Key: 1, Value: One
            // Key: 2, Value: Two
            // Key: 3, Value: Three

            sortedDictionary.Remove(3);
            sortedDictionary.ContainsKey(3);
            sortedDictionary.ContainsValue("One");

        }
    }
}
