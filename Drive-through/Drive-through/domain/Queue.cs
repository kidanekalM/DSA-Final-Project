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
    public class Queue<T>
    {
        Node<T> front;
        Node<T> back;

        public T getBack()
        {
            if(back != null)
            {
                return back.data;

            }
            return default(T);
        }
        public void Enqueue(T dt)
        {
            Node<T> newNode = new Node<T>();
            newNode.data = dt;
            newNode.next = null;
            if (front == null)
                front = back = newNode;
            else
            {
                back.next = newNode;
                back = newNode;
            }
        }

        public T Dequeue()
        {
            if(front != null)
            {
                Node<T> temp = front;
                front = front.next;
                T curData = temp.data;
                temp = null;
                GC.Collect();
                return curData;
            }
            return default;
        }

        public bool isEmpty()
        {
            if (front == null)
            {
                return true;
            }
            return false;
        }

        public T frontOfQueue()
        {
            if (isEmpty())
            {
                return default(T);
            }
            else
            {
                Node<T> tem = front;
                return tem.data; ;
            }
        }

    }
}
