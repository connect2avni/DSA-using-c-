using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsapratice
{
    public class QueueLinkedList
    {
        public class Node
        {
            public int element;
            public Node next;
            public Node(int e, Node n)
            {
                element = e;
                next = n;

            }
        }
        class QueuesLinked
        {
            Node front;
            Node rear;
            int size;

            public QueuesLinked()
            {
                front = null;
                rear = null;
                size = 0;
            }
            public int length()
            
            {
                return size;
            } 
            public bool isEmpty()
            {
                return size == 0;
            }
            public void enqueue(int e)
            {
                Node newest= new Node (e,null)


                if (isEmpty())
                    front = newest;
                else
                    rear.next = newest;
                rear = newest;
                size = size + 1;
                
            }

            static void Main(string[] args)
            {

            }
        }
    }
}
