﻿using System;
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
            Search(element, ref parent, ref currentNode);//Check if the new data is alreday in the tree
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

    }


    class Program
    {
        static void Main(string[] args)
        {


        }
    }
}
