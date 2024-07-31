using System.Collections.Generic;

namespace LinkListAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(2);
            list.AddLast(1);
            list.AddFirst(3);
            list.AddFirst(4);
            LinkedListNode<int> newNode = new LinkedListNode<int>(5);
            LinkedListNode<int> preNode = list.Find(4);
            list.AddBefore(preNode, newNode);
            newNode = new LinkedListNode<int>(7);
            LinkedListNode<int> postNode = list.Find(4);
            list.AddAfter(postNode, newNode);
           
            foreach (int i in list)
            {
                Console.Write(i.ToString()+" ");
            }
            Console.Write("\n");
            list.RemoveFirst();
            list.RemoveLast();
            list.Remove(3);
            Console.Write("\n");
            var l =list.Reverse();
            Console.Write("\n");
           
            foreach (int i in l)
            {
                Console.Write(i + " ");
            }

        }
    }
}
