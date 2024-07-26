namespace LinkListManual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkList<int> list = new LinkList<int>(); 
            list.AddFirst(4);
            list.AddBefore(4,3);
            list.AddBefore(4, 6);
            list.Print();

          
            
         
           
        }
    }
}
