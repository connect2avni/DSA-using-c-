/*using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsapratice
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
    class DeQueLink
    {
        private Node front;
        private Node rear;
        private int size;

        public DeQueLink()
        {
            front= null;
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
        public void addLast(int e)
        {
            Node newest = new Node(e, null);
            if (isEmpty())
                front = newest;
            else
                rear = newest;
            size = size + 1;
        }

        //adding element at beginning of linked list.
        public void addFirst(int e)
        {
            Node newest = new Node(e, null);
            if (isEmpty())
            {
                front = newest;
                rear = newest;

            }
            else
            {
                newest.next = front;
                rear= newest;
            }
            size = size + 1;
        }
        
        //removing first element from linked list
        public int removeFirst()
        {
            if (isEmpty())
            {
                Console.WriteLine("List is Empty");
                return -1;

            }
            else
            {
                int e = front.element;
                front= front.next;
                size = size - 1;
                if (isEmpty())
                    rear = null;
                return e;

            }
        }
        //removing last element of linked list
        public int removeLast()
        {
            if (isEmpty())
            {
                Console.WriteLine("List is empty");
                return -1;

            }
            Node p = front;
            int i = 1;
            while (i < size - 1)
            {
                p = p.next;
                i = i + 1;
            }
            rear = p;
            p = p.next;
            int e = p.element;
            rear.next = null;
            size = size - 1;
            return e;

        }
        //inserting elements in sorted order in linked list
        public void insertsorted(int e)
        {
            Node newest = new Node(e, null);
            if (isEmpty())
                front = newest;
            else
            {
                Node p = front;
                Node q = front;
                while (p != null && p.element < e)
                {
                    q = p;
                    p = p.next;

                }
                if (p == front)
                {
                    newest.next = front;
                    front = newest;
                }
                else
                {
                    newest.next = q.next;
                    q.next = newest;
                }
            }
            size = size + 1;
        }
        public void display()
        {
            Node p = front;
            while (p != null)
            {
                Console.WriteLine(p.element + " ");
                p = p.next;

            }
            Console.WriteLine();
        }

        public int first()
        {
            if(isEmpty())
            {
                Console.WriteLine("DeQueue is Empty");
                return -1;
            }
            return front.element;
        }
        public int last()
        {
            if(isEmpty())
            {
                Console.WriteLine("Dequeue is Empty");
                return -1;
            }
            return rear.element;
        }
        static void Main(string[] args)
        {
            DeQueLink d = new DeQueLink();
            d.addFirst(5);
            d.addFirst(3);
            d.addLast(7);
            d.addLast(12);
            d.display();
            Console.WriteLine("Size:" +d.length);
            Console.WriteLine("Front Element Removed:" +d.removeLast());
            Console.WriteLine("Rear Element Removed:" + d.removeFirst());
            d.display();
            Console.WriteLine("First element:" +d.first());
            Console.WriteLine("Last element:" + d.last());
            Console.ReadKey();



        }
    }
}
*/