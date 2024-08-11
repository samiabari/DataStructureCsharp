using System.Collections.Concurrent;

namespace BlockingCollectionAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<int> blockingCollection = new BlockingCollection<int>(boundedCapacity: 5);

            // Producer Task
            Task producer = Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    blockingCollection.Add(i);
                    Console.WriteLine($"Produced: {i}");
                    Thread.Sleep(100);
                }
                blockingCollection.CompleteAdding();
            });

            // Consumer Task
            Task consumer = Task.Run(() =>
            {
                foreach (var item in blockingCollection.GetConsumingEnumerable())
                {
                    Console.WriteLine($"Consumed: {item}");
                    Thread.Sleep(150);
                }
            });

            Task.WaitAll(producer, consumer);
        }
    }
}
