namespace StackAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> elements=new Stack<int>();
            elements.Push(1);
            elements.Push(2);
            elements.Push(3);
            elements.Push(4);
            elements.Contains(4);
            elements.Clear();
            elements.Pop();
            elements.Count();
        }
    }
}
