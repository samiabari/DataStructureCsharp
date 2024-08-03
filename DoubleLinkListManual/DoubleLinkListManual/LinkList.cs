using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkListManual
{
    public class LinkList<T>
    {
        public Node<T> Head { set; get; }
        public Node<T> Tail { set; get; }

        public LinkList()
        {
            this.Head = null;
            this.Tail = null;
        }

        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (Head == null && Tail==null)
            {
                Head = newNode;
                Tail= newNode;
            }
            else
            {
                Head.Prev = newNode;
                newNode.Next = Head;
                Head = newNode;
            }
        }

        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (Head == null && Tail == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                newNode.Prev = Tail;
                Tail = newNode;
            }
        }


        public void AddAfter(T keyData, T newData)
        {
            Node<T> newNode = new Node<T>(newData);
            if (Head == null && Tail == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Node<T> current = Head;

                while (!current.Data.Equals(keyData))
                {
                    current = current.Next;
                }
                newNode.Prev = current;
                if (current.Next == null)
                {
                    current.Next = newNode;
                    Tail = newNode;
                }
                else
                {
                    current.Next.Prev = newNode;
                    newNode.Next = current.Next;
                    current.Next = newNode;
                }
            }
        }

        public void AddAfterNode(Node<T> keyNode, T newData)
        {
            Node<T> newNode = new Node<T>(newData);
            if (Head == null && Tail == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Node<T> current = Head;

                while (!current.Equals(keyNode))
                {
                    current = current.Next;
                }
                newNode.Prev = current;
                if (current.Next == null)
                {
                    current.Next = newNode;
                    Tail = newNode;
                }
                else
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                }
            }
        }

        public void AddBefore(T keyData, T newData)
        {
            Node<T> newNode = new Node<T>(newData);
            if (Head == null && Tail == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else if (Tail.Data.Equals(keyData))
            {
                newNode.Prev= Tail.Prev;
                Tail.Prev.Next= newNode;
                newNode.Next = Tail;
                Tail.Prev = newNode;
            }
            else
            {
                Node<T> current = Tail;
                while (!current.Data.Equals(keyData))
                {
                    current = current.Prev;
                }
                if (current.Prev == null)
                {
                    current.Prev = newNode;
                    newNode.Next = current;
                    Head = newNode;
                }
                else {
                    current.Prev.Next= newNode;
                    newNode.Prev = current.Prev;
                    current.Prev = newNode;
                    newNode.Next = current;
                    
                }
                
            }
        }


        public void AddBeforeNode(Node<T> keyNode, T newData)
        {
            Node<T> newNode = new Node<T>(newData);
            if (Head == null && Tail == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else if (Tail.Equals(keyNode))
            {
                newNode.Prev = Tail.Prev;
                newNode.Next = Tail;
                Tail = newNode;
            }
            else
            {
                Node<T> current = Tail;
                while (!current.Prev.Equals(keyNode))
                {
                    current = current.Prev;
                }
                if (current.Prev == null)
                {
                    current.Prev = newNode;
                    newNode.Next = current;
                    Head = newNode;
                }
                else
                {
                    current.Prev.Next = newNode;
                    newNode.Prev = current.Prev;
                    current.Prev = newNode;
                    newNode.Next = current;

                }

            }
        }



        public Node<T> FindFirst(T keyData)
        {

            if (Head == null && Tail == null)
            {
                return null;
            }

            else
            {
                Node<T> current = Head;
                while (!current.Data.Equals(keyData))
                {
                    current = current.Next;
                }

                return current;
            }
        }

        public Node<T> FindLast(T keyData)
        {

            if (Head == null && Tail == null)
            {
                return null;
            }

            else
            {

                Node<T> current = Tail;
                while (!current.Data.Equals(keyData))
                {
                    current = current.Prev;
                }

                return current;
            }
        }


        public bool Remove(T keyData)
        {
            if (Head == null && Tail == null)
            {
                return false;
            }
            else if (Head.Data.Equals(keyData))
            {

                Head = Head.Next;
                Head.Prev = null;
                return true;
            }
            else if (Tail.Data.Equals(keyData))
            {
                Tail = Tail.Prev;
                Tail.Next = null;
                return true;
            }
            else
            {
                Node<T> current = Head;
                while (!current.Data.Equals(keyData))
                {
                    current = current.Next;
                }
                current.Prev.Next = current.Next;
                current.Next.Prev = current.Prev;
                return true;
            }
        }

        public bool RemoveFirst()
        {

            if (Head == null && Tail == null)
            {
                return false;
            }
            else if (Head.Next == null && Tail.Prev==null)
            {
                Head = null;
                Tail = null;
                return true;
            }
            else
            {
                Head = Head.Next;
                Head.Prev = null;
                return true;
            }
        }

        public bool RemoveLast()
        {

            if (Head == null && Tail == null)
            {
                return false;
            }
            else if (Head.Next == null && Tail.Prev == null)
            {
                Head = null;
                Tail = null;
                return true;
            }
            else
            {
                Tail=Tail.Prev;
                Tail.Next = null;
                return true;
            }
        }

        public void Print()
        {
            if (Head == null && Tail == null)
            {
                Console.WriteLine("List Empty");
            }
            else
            {
                Console.WriteLine("Existing List: ");
                Node<T> current = Head;
                while (current != null)
                {
                    Console.Write(current.Data + " ");

                    if (current.Next != null)
                    {
                        Console.Write("->");
                    }
                    else
                    {
                        Console.Write("\n");
                    }
                    current = current.Next;
                }
            }

        }


    }
}
