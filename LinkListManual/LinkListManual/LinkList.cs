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

        public void Add(T data)
        {
            Node<T> newNode= new Node<T>(data);

            if (Head == null)
            {
                Head = newNode;
            }
            else {

                Node<T> current= Head;

                while (current.Next != null)
                {
                    current= current.Next;
                }
                current.Next = newNode;
            }
        }

        public bool Delete(T data)
        {
            if (Head == null)
            {
                return false;
            }
            else
            {
                Node<T> current = Head;

                while (current.Next != null && !current.Next.Data.Equals(data))
                {
                    current=current.Next;
                }
                if (current.Next != null && current.Next.Data.Equals(data))
                {
                    current.Next = current.Next.Next;
                    return true;
                }
                return false;
            }
        }


        public bool Search(T data)
        {
            if (Head == null)
            {
                return false;
            }
            else 
            {
                Node<T> current = Head;

                while (current.Next != null && !current.Data.Equals(data))
                {
                    current = current.Next;
                }

                if (current.Data.Equals(data))
                {
                    return true;
                } 
                return false;
            }
        }


        public string Print()
        {
            string s = "";
            if (Head == null)
            {
                s = "No Data found";
            }
            else
            {
                Node<T> current = Head;

                while (current.Next != null)
                {

                    if (current.Next != null)
                    {
                        s = s + current.Data + " -> ";
                    }
                    
                    current = current.Next;
                }

                s = s + current.Data+ "\n";
            }

            return s;
        }

        

    }
}
