namespace LinkListManual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkList<int> list = new LinkList<int>(); 

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);    
            list.Add(10);
            Console.WriteLine(list.Print());
            Console.WriteLine(list.Delete(11));
            Console.WriteLine(list.Print());
        }
    }
}
