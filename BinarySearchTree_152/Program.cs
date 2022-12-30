using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_152
{

    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;

        //Conustructor for thhe node class 

        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;

        }
    }
    
    /* A node class consists from three things,
     * the informaiton,
     * refrence to the right child, 
     * and refrence to the left child */
    class BinaryTree
    {
        public Node ROOT;

        public BinaryTree()
        {
            ROOT = null; //initalizing root to null

        }

        public void insert(string element) // insert a node in the binary search tree
        {
            Node tmp, parent = null, currentNode = null;
            search(element, ref parent, ref currentNode);//Check if the new data is alreday in the tree
            if (currentNode != null)
            {
                Console.WriteLine("Duplicates are not allowed");
                return;
            }
            else
            {
                tmp = new Node(element,null,null);//creates a node
                if (parent == null)//if tree is empty
                {
                    ROOT = tmp;
                }
                else if (string.Compare(element, parent.info) < 0)
                {
                    parent.leftchild= tmp;
                }
                else
                {
                    parent.rightchild= tmp;
                }
            }

        }
        public void search(string element, ref Node parent, ref Node currentNode)
        {


            currentNode = ROOT;
            parent = null;
            while((currentNode != null) && (currentNode.info != element))
            {
                parent = currentNode;
                if (string.Compare(element, currentNode.info) < 0)
                {
                    currentNode = currentNode.leftchild;
                }
                else
                {
                    currentNode = currentNode.rightchild;
                }
            }

        }
        public void inorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return ;
            }
            if (ptr != null)
            {
                inorder(ptr.leftchild);
                Console.Write(ptr.info + "  ");
                inorder(ptr.rightchild);
            }
        }

        public void preorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine(" Tree is empty");
                return;
            }
            if (ptr != null)
            {
                Console.Write(ptr.info + "  ");
                preorder(ptr.leftchild);
                preorder(ptr.rightchild);
            }
        }

        public void postorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.Write("Tree is empty");
            }
            if(ptr != null)
            {
                postorder(ptr.leftchild);
                postorder(ptr.rightchild);
                Console.Write(ptr.info + "  ");

            }
        }


    }


    class Program
    {
        static void Main(string[] args)
        {


        }
    }
}
