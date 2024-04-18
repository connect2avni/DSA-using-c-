/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsapratice
{
    public class Node
    {
        public int element;
        public Node next;
        public Node prev;

        public Node(int e, Node n, Node p )
        {
            element = e;
            next = n;
            prev = p;

        }

    }

    class DoublyLinkedList
    {
        private Node head;
        private Node tail;
        private int size;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
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
            Node newest = new Node(e, null, null);
            if(isEmpty())
            {
                head= newest;
                tail = newest;

            }
            else
            {
                tail.next = newest;
                newest.prev = tail;
                tail = newest;

            }
            size = size + 1;
        }

        //insert element at beginning of linked list
        public void addFirst(int e)
        {
            Node newest = new Node(e, null, null);
            if(isEmpty())
            {
                head= newest;
                tail = newest;
            }
            else
            {
                newest.next = head;
                head.prev = newest;
                head = newest;
            }
            size = size + 1;
        }
        //insert element anywhere in between the doubly linked list

        public void addAny(int e, int position)
        {
            if(position <=0 || position >= size)
            {
                Console.WriteLine("Invalid Position");
                return;

            }
            Node newest = new Node(e,null, null);
            Node p = head;
            int i = 1;
            while(i< position-1)
            {
                p = p.next;
                i = i + 1;

            }
            newest.next = p.next;
            p.next.prev = newest;
            p.next = newest;
            newest.prev = p;
            size = size + 1;



        }

        //remove element from beginning of linked list
        public int removeFirst()
        {
            if(isEmpty())
            {
                Console.WriteLine("Doubly list is Empty");
                return -1;
            }
            int e = head.element;
            head = head.next;
            size = size - 1;
            if (isEmpty())
                tail = null;
            else
                head.prev = null;
            return e;

        }
        //removing last element fron doubly linked list

        public int removeLast()
        {
            if(isEmpty())
            {
                Console.WriteLine("Doubly list is empty");
                return -1;
            }
            int e = tail.element;
            tail = tail.prev;
            size= size - 1;
            return e;
        }
        //remove element from anywhere in doubly linked list
        public int removeAny(int position)
        {
            if(position<=0 || position >=size-1)
            {
                Console.WriteLine("invalid position");
                return -1;
            }
            Node p = head;
            int i = 1;
            while(i<position-1)
            {
                p = p.next;
                i = i = i + 1;

            }
            int e = p.next.element;
            p.next = p.next.next;
            p.next.prev = p;
            size = size - 1;
            return e;
        }

        public void display()
        {
            Node p = head;
            while( p != null )
            {
                Console.Write(p.element+ "--->");
                p= p.next;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            DoublyLinkedList l= new DoublyLinkedList();
            l.addLast(7);
            l.addLast(4);
            l.addLast(12);
            l.addLast(8);
            l.addLast(3);
            l.display();
            Console.WriteLine("Size:" +l.length());

            int element = l.removeAny(3);
            Console.WriteLine("Removed element :" + element);
            l.display() ;
            Console.WriteLine("Size:" + l.length());


            *//*  l.removeLast();
              int element = l.removeLast();
              Console.WriteLine("Removed Element:" + element);
              l.display();
              Console.WriteLine("Size:" + l.length());*/


            /* l.addFirst(15);
             l.display();
             Console.WriteLine("Size:" +l.length());
             int element=l.removeFirst();
             Console.WriteLine("Removed Element: " + element);
             l.display();
             Console.WriteLine("Size:" +l.length());

             l.addAny(20, 3);


 *//*

            Console.ReadKey();
        }

    }
}
*/