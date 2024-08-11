using System.Collections.Concurrent;

namespace ConcurrentQueueAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a ConcurrentQueue
            ConcurrentQueue<int> concurrentQueue = new ConcurrentQueue<int>();

            // Enqueue elements
            concurrentQueue.Enqueue(1);
            concurrentQueue.Enqueue(2);
            concurrentQueue.Enqueue(3);

            // Dequeue elements
            if (concurrentQueue.TryDequeue(out int result))
            {
                Console.WriteLine($"Dequeued: {result}");
            }

            // Iterate over the ConcurrentQueue
            foreach (var item in concurrentQueue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
