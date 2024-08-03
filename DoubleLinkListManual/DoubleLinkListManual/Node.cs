using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkListManual
{
    public class Node<T> 
    {

        public T Data { set; get; }
        public Node<T> Prev { set; get; }
        public Node<T> Next { set; get; }

        public Node(T data)
        {
            this.Data = data;
            this.Prev = null;
            this.Next = null;
        }

    }
}
