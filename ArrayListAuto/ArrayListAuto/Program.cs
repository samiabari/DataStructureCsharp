using System.Collections;

namespace ArrayListAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);          // Adds an integer
            arrayList.Add("Hello");    // Adds a string
            arrayList.Add(3.14);       // Adds a double

            // Access elements in the ArrayList
            int firstElement = (int)arrayList[0];        // Casting required
            string secondElement = (string)arrayList[1]; // Casting required
            double thirdElement = (double)arrayList[2];

            arrayList.Contains(1);
            arrayList.Reverse();
        }
    }
}
