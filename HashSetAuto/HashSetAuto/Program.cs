namespace HashSetAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> s=new HashSet<int>();
            s.Add(1);
            s.Add(2);
            s.Add(3);
            s.Add(4);
            s.Contains(5);
            s.Clear();
        }
    }
}
