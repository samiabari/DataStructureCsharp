namespace DictionaryHashMapAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, char> dict=new Dictionary<int, char>();
            dict.Add(1, 'a');
            dict.Add(2, 'b');
            dict.Add(3, 'c');
            dict.ContainsKey(3);
            dict.Remove(3);
            dict.ContainsValue('b');
           
        }
    }
}
