using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackManual
{
    public class Stack<T>
    {
        public T[]? Elements { set; get; }
        public int Size { set; get; }

        public int Top { set; get; }
        public int Max { set; get; }

        public Stack(int _size) { 
        this.Size = _size;
            Elements = new T[this.Size];
            this.Max = this.Size;
            this.Top = -1;
        }

        
        public bool Push(T element)
        {
            if (Top == Max - 1)
            {
                return false;
            }
            else 
            {
                Top++;
                Elements[Top]= element;
                return true;
            }
        }

        public T Pop()
        {
            if (Top == - 1)
            {
                Console.WriteLine("underflow");
                return default(T);
            }
            else
            {
               T result= Elements[Top];
               Elements[Top] = default(T);
               Top--;
               return result;
            }
        }

        public T Peek(T element)
        {
            if (Top == -1)
            {
                Console.WriteLine("underflow");
                return default(T);
            }
            else
            {
                return Elements[Top];
                
            }
        }


        public bool Contains(T keyData)
        {
            if (Top == -1)
            {
                return false;
            }
            else
            {
                for (int i=0; i<Top; i++)
                {
                    if (Elements[i].Equals(keyData))
                    {
                        return true;
                    }

                }
                return false;
            }
        }


        public int Count()
        {
            int count = 0;
            if (Top == -1)
            {
                return -1;
            }
            else
            {
                for (int i = 0; i < Top; i++)
                {
                    count++;
                }
                return count;
            }
        }
    }
}
