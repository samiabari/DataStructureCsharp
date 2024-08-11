namespace CSharpListAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> li=new List<int>();
            li.Add(1);
            li.Add(2);
            li.Add(3);
            li.Add(4);
            li.Capacity = 5;
            li.Add(1);
            li.Add(2);
            li.AddRange(li);
        }
    }
}
