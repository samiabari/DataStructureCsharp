﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LinkListManual
{
    public class LinkList<T>
    {
        public Node<T> Head { set; get; }
        

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

        public void AddAfterNode(Node<T> keyNode, T newData)
        {
            Node<T> newNode = new Node<T>(newData);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node<T> current = Head;

                while (!current.Equals(keyNode))
                {
                    current = current.Next;
                }
                if (current.Next == null)
                {
                    current.Next = newNode;
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


        public void AddBeforeNode(Node<T> keyNode, T newData)
        {
            Node<T> newNode = new Node<T>(newData);
            if (Head == null)
            {
                Head = newNode;
            }
            else if (Head.Equals(keyNode))
            {
                newNode.Next = Head;
                Head = newNode;
            }
            else
            {
                Node<T> current = Head;
                while (!current.Next.Equals(keyNode))
                {
                    current = current.Next;
                }
                newNode.Next = current.Next;
                current.Next = newNode;

            }
        }



        public Node<T> FindFirst(T keyData)
        {
            
            if (Head == null)
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

            if (Head == null)
            {
                return null;
            }

            else
            {
                Node<T> current = Head;
                Node<T> last = Head;
                while (current!=null)
                {
                    if (current.Data.Equals(keyData))
                    {
                        last = current;
                    }
                    if (current.Next == null)
                    {
                        break;
                    }
                    else {
                        current = current.Next;
                    }
                    
                }

                return last;
            }
        }


        public bool Remove(T keyData)
        {
            if (Head == null)
            {
                return false;
            }
            else if (Head.Data.Equals(keyData))
            {
               
                Head = Head.Next;
                return true;
            }
            else
            {
                Node<T> current = Head;
                while (!current.Next.Data.Equals(keyData))
                {
                    current = current.Next;
                }
                current.Next = current.Next.Next;
                return true;
            }
        }

        public bool RemoveFirst()
        {

            if (Head == null)
            {
                return false;
            }
            else if (Head.Next == null)
            {
                Head = null;
                return true;
            }
            else
            {
                Head= Head.Next;
                return true;
            }
        }

        public bool RemoveLast()
        {
           
            if (Head == null)
            {
               return  false;
            }
            else
            {
                Node<T> current = Head;

                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
                return true;

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
