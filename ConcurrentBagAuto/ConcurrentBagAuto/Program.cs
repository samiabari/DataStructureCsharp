using System.Collections.Concurrent;

namespace ConcurrentBagAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> concurrentBag = new ConcurrentBag<int>();

            // Add elements to the ConcurrentBag
            concurrentBag.Add(1);
            concurrentBag.Add(2);
            concurrentBag.Add(3);

            // Try to take an element from the ConcurrentBag
            if (concurrentBag.TryTake(out int result))
            {
                Console.WriteLine($"Taken: {result}");
            }

            // Peek at an element (non-destructive)
            if (concurrentBag.TryPeek(out int peek))
            {
                Console.WriteLine($"Peeked: {peek}");
            }

            // Iterate over the ConcurrentBag
            foreach (var item in concurrentBag)
            {
                Console.WriteLine(item);
            }
        }
    }
}
