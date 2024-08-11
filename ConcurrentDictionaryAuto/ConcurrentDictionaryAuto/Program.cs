using System.Collections.Concurrent;

namespace ConcurrentDictionaryAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a ConcurrentDictionary
            ConcurrentDictionary<int, string> concurrentDictionary = new ConcurrentDictionary<int, string>();

            // Add key-value pairs to the ConcurrentDictionary
            concurrentDictionary[1] = "One";
            concurrentDictionary[2] = "Two";
            concurrentDictionary[3] = "Three";

            // Try to add a new key-value pair
            if (concurrentDictionary.TryAdd(4, "Four"))
            {
                Console.WriteLine("Added key 4");
            }

            // Try to update an existing key-value pair
            if (concurrentDictionary.TryUpdate(2, "Second", "Two"))
            {
                Console.WriteLine("Updated key 2");
            }

            // Iterate over the ConcurrentDictionary
            foreach (var entry in concurrentDictionary)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
            
        }
    }
}
