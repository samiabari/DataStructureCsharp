using System.Collections;

namespace HashTableAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();

            // Add key-value pairs to the Hashtable
            hashtable.Add(1, "Apple");
            hashtable.Add(2, "Banana");
            hashtable.Add(3, "Cherry");

            hashtable.Contains(1);
            hashtable.ContainsValue("Apple");
            hashtable.ContainsKey(1);
           string s= (string) hashtable[1];
        }
    }
}
