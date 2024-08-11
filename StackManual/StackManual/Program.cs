namespace StackManual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>(4);
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);
            st.Pop();
            Console.WriteLine(st.Count());
            Console.WriteLine(st.Contains(5));
        }
    }
}
