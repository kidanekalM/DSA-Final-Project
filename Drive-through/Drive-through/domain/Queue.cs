using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Drive_through.domain
{
    class Node<T>
    {
        public T data;
        public Node<T> next;
    }
    internal class Queue<T>
    {
        Node<T> front;
        Node<T> back;
        T Dequeue()
        {
            Node<T> temp = front;
            front = front.next;
            T curData = temp.data;
            temp = null;
            GC.Collect();
            return curData;
        }
    }
}
