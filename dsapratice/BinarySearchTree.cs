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
        public Node left;
        public Node right;

        public Node(int e, Node l, Node r )
        {
            element = e;
            left = l;
            right = r;
        }
    }
    class BinarySearchTree
    {
        Node root;
        public BinarySearchTree()
        {
            root = null;
        }
        *//*public void insert(Node temproot,int e)
        {
            Node temp = null;
            while( temproot != null )
            {
                temp = temproot;
                if (e == temproot.element)
                    return;
                else if (e < temproot.element)
                    temproot = temproot.left;
                else if(e > temproot.element)
                    temproot = temproot.right;

                
            }
            Node n = new Node(e, null, null);
            if (root != null)
            {
                if (e < temp.element)
                    temp.left = n;
                else
                    temp.right = n;
            }
            else
                root = n;
        }*//*
        //recursive
        public Node insert(Node temproot, int e)
        {
            if (temproot != null)
            {
                if (e < temproot.element)
                    temproot.left = insert(temproot.left, e);
                else if (e > temproot.element)
                    temproot.right = insert(temproot.right, e);
            }
            else
            {
                Node n = new Node(e, null, null);
                temproot = n;
            }
            return temproot;
        }
        

            
        public void inorder(Node temproof)
        {
            if(temproof!= null)
            {
                inorder(temproof.left);
                Console.Write(temproof.element + " ");
                inorder(temproof.right);
            }
        }
        public void preorder(Node temproot)
        {
            if(temproot!= null)
            {
                Console.Write(temproot.element +" ") ;
                preorder(temproot.left);
                preorder(temproot.right);

            }
        }
        public void postorder(Node temproot)
        {
            if(temproot!= null)
            {
                postorder(temproot.left);
                postorder(temproot.right);
                Console.WriteLine(temproot.element+ " ");
            }
        }
        static void Main(string[] args)
        {
            BinarySearchTree B = new BinarySearchTree();
            B.insert(B.root,50);
            B.insert(B.root,30);
            B.insert(B.root,80);
            B.insert(B.root,10);
            B.insert(B.root,40);
            B.insert(B.root,60);
            B.insert(B.root,90);
            Console.WriteLine("inorder traversal");
            B.inorder(B.root);
            Console.WriteLine();
            Console.WriteLine("Preorder traversal");
            B.preorder(B.root);
            Console.WriteLine();
            Console.WriteLine("Post order traversal");
            B.postorder(B.root);
            Console.ReadKey();

        }
    }
}
*/