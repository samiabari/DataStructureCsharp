namespace QueueManual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> qu = new Queue<int>(4);
            qu.Enqueue(5);
            qu.Dequeue();
            qu.Dequeue();
            qu.Enqueue(6);
            qu.Enqueue(7);
            qu.Enqueue(8);
            Console.WriteLine(qu.Contains(7));
            Console.WriteLine(qu.Dequeue());
            Console.WriteLine(qu.Peek());
            Console.WriteLine(qu.Count());
        }
    }
}
