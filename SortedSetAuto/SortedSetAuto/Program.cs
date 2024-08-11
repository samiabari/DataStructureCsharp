namespace SortedSetAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> sortedSet = new SortedSet<int>();

            // Add elements to the SortedSet
            sortedSet.Add(3);
            sortedSet.Add(1);
            sortedSet.Add(2);

            // Iterate over the SortedSet
            foreach (var item in sortedSet)
            {
                Console.WriteLine(item);
            }
            // Output will be sorted:
            // 1
            // 2
            // 3
            sortedSet.RemoveWhere(x => x != 3);
                sortedSet.UnionWith(sortedSet);
            sortedSet.Contains(3);

        }
    }
}
