using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LinkListManual
{
    internal class LinkList<T>
    {
        Node<T> Head { set; get; }
        

        public LinkList()
        {
            this.Head = null;
        }

        public void AddFirst(T data)
        {
            Node<T> newNode= new Node<T>(data);
            if (Head == null)
            {
                Head = newNode;
            }
            else {
                newNode.Next= Head;
                Head= newNode;
            }
        }

        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node<T> current = Head;

                while (current.Next != null)
                {
                    current= current.Next;
                }
                if (current.Next == null)
                {
                    current.Next= newNode;
                }
            }
        }


        public void AddAfter(T keyData,T newData)
        {
            Node<T> newNode = new Node<T>(newData);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node<T> current = Head;

                while (!current.Data.Equals(keyData))
                {
                    current = current.Next;
                }
                if (current.Next == null)
                {
                    current.Next = newNode;
                }
                else {
                    newNode.Next = current.Next;
                    current.Next= newNode;
                }
            }
        }


        public void AddBefore(T keyData, T newData)
        {
            Node<T> newNode = new Node<T>(newData);
            if (Head == null)
            {
                Head = newNode;
            }
            else if (Head.Data.Equals(keyData))
            {
                newNode.Next = Head;
                Head=newNode;
            }
            else
            {
                Node<T> current= Head;
                while (!current.Next.Data.Equals(keyData))
                {
                    current = current.Next;
                }
                newNode.Next= current.Next;
                current.Next = newNode;

            }
        }

        public void Print()
        {
            if (Head == null)
            {
                Console.WriteLine("List Empty");
            }
            else {
                Console.WriteLine("Existing List: ");
                Node<T> current = Head;
                while (current != null)
                {
                    Console.Write(current.Data +" ");

                    if (current.Next != null)
                    {
                        Console.Write("->");
                    }
                    else {
                        Console.Write("\n");
                    }
                    current = current.Next;
                }
            }

        }


    }
}
