namespace LinkListManual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkList<int> list = new LinkList<int>(); 
            list.AddFirst(5);
            list.AddFirst(3);
            list.AddFirst(1);
            Node<int> node = list.FindFirst(3); 
            list.AddAfterNode(node,4);

            list.Print();

        }
    }
}
