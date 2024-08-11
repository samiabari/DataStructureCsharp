using System.Collections.Concurrent;

namespace ConcurrentStackAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcurrentStack<int> concurrentStack = new ConcurrentStack<int>();

            // Push elements onto the ConcurrentStack
            concurrentStack.Push(1);
            concurrentStack.Push(2);
            concurrentStack.Push(3);

            // Pop elements from the ConcurrentStack
            if (concurrentStack.TryPop(out int result))
            {
                Console.WriteLine($"Popped: {result}");
            }

            // Peek the top element
            if (concurrentStack.TryPeek(out int top))
            {
                Console.WriteLine($"Top element: {top}");
            }

            // Iterate over the ConcurrentStack
            foreach (var item in concurrentStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
