using System.Collections;

namespace NonGenericStackAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            // Push elements onto the Stack
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");

            // Pop elements from the Stack
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

            stack.Peek();
            stack.Contains("R");

        }
    }
}
