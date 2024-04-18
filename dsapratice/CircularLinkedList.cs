﻿/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace dsapratice
{

    public class Node
    {
        public int element;
        public Node next;
        public Node(int e,Node n)
        {
            element = e;
            next = n;

        }
    }
    public class CircularLinkedList
    {
        private Node head;
        private Node tail;
        private int size;
        public CircularLinkedList()
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
            Node newest = new Node(e, null);
            if (isEmpty())
            {
                newest.next = newest;
                head = newest;

            }
            else
            {
                newest.next = tail.next;
                tail.next = newest;
            }
            tail = newest;
            size = size + 1;

        }
        //adding element in beginning of linked list
        public void addFirst(int e)
        {
            Node newest = new Node(e, null);
            if(isEmpty())
            {
                newest.next = newest;
                head= newest;
                tail = newest;

            }
            else
            {
                tail.next= newest;
                newest.next = head;
                head = newest;
            }
        }
        //adding element in middle of linked list

        public void addAny(int e,int position)
        {
            if(position <=0|| position>=size)
            {
                Console.WriteLine("Invalid position");
                return;
            }
            Node newest = new Node(e, null);
            Node p = head;
            int i = 1;
            while(i< position-1)
            {
                p= p.next;
                i = i + 1;
            }
            newest.next = p.next;
            p.next = newest;
            size=size+ 1;
        }

        //removing element at beginning of linked list
        public int removeFirst()
        {
            if (isEmpty())
            {
                Console.WriteLine("Circular List is Empty");
                return -1;
            }
            int e = head.element;
            tail.next = head.next;
            head = head.next;
            size = size - 1;
            if(isEmpty())
            {
                head = null;
                tail = null;
            }
            return e;
        }

        //delete element at end of circular linked list

        public int removeLast()
        {
            if(isEmpty())
            {
                Console.WriteLine("Circular list is empty");
            return -1;
            }
            Node p = head;
            int i = 1;
            while(i<length()-1)
            {
                p=p.next;
                i= i + 1;
            }
            tail = p;
            p = p.next;
            tail.next = p;
            int e = p.element;
            size = size - 1;
            return e;
        }

        //delete element anywhere in between circular linked list
        public int removeAny(int position)
        {
            if(position <=0|| position >=size-1)
            {
                Console.WriteLine("Invalid Position");
                return -1;
            }
            Node p = head;
            int i = 1;
            while(i<position-1)
            {
                p = p.next;
                i=i + 1;
            }
            int e = p.next.element;
            p.next = p.next.next;
            size = size - 1;
            return e;

        }
        



        public void display()
        {
            Node p = head;
            int i = 0;
            while(i<length())
            {
                Console.WriteLine(p.element+ "--->");
                p = p.next;
                i = i + 1;
            }
            Console.WriteLine();
        }

            static void Main(string[] args)
        {
            CircularLinkedList l = new CircularLinkedList();
            l.addLast(7);
            l.addLast(4);
            l.addLast(12);
            l.display();
            Console.WriteLine("Size"+l.length());
            //l.addAny(20, 1);
            //l.addFirst(25);

            *//*int element= l.removeFirst();
            Console.WriteLine("Removed Element:" +element);
            l.display();
            Console.WriteLine("Size" + l.length());
            Console.ReadKey();*/

            /* int element = l.removeLast();
               Console.WriteLine("Removed Element:"+ element);
               Console.ReadKey();*//*

            int element = l.removeAny(3);
            Console.WriteLine("Removed Element:" + element);
            l.display();
            Console.WriteLine("Size:" +l.length());
            Console.ReadKey();

        }
    }

}
*/