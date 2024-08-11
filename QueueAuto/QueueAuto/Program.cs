namespace QueueAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Dequeue();
            queue.Peek();
          
            Console.WriteLine(queue.Count);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Contains(2));
        }
    }
}
