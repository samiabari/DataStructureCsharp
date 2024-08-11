using System.Collections;

namespace NonGenericQueueAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            // Enqueue elements
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");

            // Dequeue elements
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }

            queue.AsParallel();
            queue.Peek();
            queue.Clear();
            queue.Contains("2");
        }
    }
}
