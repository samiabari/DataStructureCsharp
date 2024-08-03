namespace DoubleLinkListManual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkList<int> list = new LinkList<int>();
            list.AddLast(4);
            list.AddLast(3);
 
            list.AddAfter(3, 2);
            list.AddBefore(4, 5);
            list.Remove(3);
          
            list.Print();
        }
    }
}
