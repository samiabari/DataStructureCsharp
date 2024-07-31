namespace LinkListManual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkList<int> list = new LinkList<int>(); 
            list.AddFirst(4);
            list.AddBefore(4,3);
            list.AddBefore(4, 7);
            list.AddAfter(3,5);
            list.AddAfter(4, 1);
            list.AddFirst(6);
            Node<int> n = list.FindLast(6); 
            list.Print();

        }
    }
}
