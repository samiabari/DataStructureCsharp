using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueManual
{
    public class Queue<T>
    {
        public T[] Elements;
        public int Size { set; get; }
        public int Max { set; get; }
        public int Front {set;get;}
        public int Rear {set;get;}
        public Queue(int size) {
            Elements = new T[size];
            this.Front = 0;
            this.Size = size;
            this.Max = size-1;
            this.Rear = -1;

        }

        public bool Enqueue(T element)
        {
            if (Rear >= Max)
            {
                Console.WriteLine("queue is full..");
                return false;
            }
            else 
            {
                Rear++;
                Elements[Rear]=element; 
                return true;
            }
        }





        public T Dequeue()
        {
            if (Front > Rear)
            {
                Console.WriteLine("UnderFlow");
                return default(T);
            }
            else
            {
                T result = Elements[Front];
               
                for (int i = 0; i < Rear; i++)
                {
                    Elements[i] = Elements[i + 1];
                }
                Rear--;
                return result;
            }
        }


        public T Peek()
        {
            if (Front > Rear)
            {
                Console.WriteLine("UnderFlow");
                return default(T);
            }
            else
            {
                return Elements[Front];
            }
        }


        public int Count()
        {
            int count = 0;
            if (Front > Rear)
            {
                Console.WriteLine("UnderFlow");
                return 0;
            }
            else if (Rear > Max)
            {
                return 0;
            }
            else
            {
                for (int i = Front; i <= Rear; i++)
                {
                    count++;
                }
                return count;
            }
        }


        public bool Contains(T keyData)
        {
            int count = 0;
            if (Front > Rear)
            {
                Console.WriteLine("UnderFlow");
                return false;
            }
            else if (Rear > Max)
            {
                return false;
            }
            else
            {
                for (int i = Front; i <= Rear; i++)
                {
                    if (Elements[i].Equals(keyData))
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
