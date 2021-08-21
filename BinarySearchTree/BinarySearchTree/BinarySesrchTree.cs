using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class BinarySearchTree<T> where T : IComparable
    {
        int size = 0; 
        public Node<T> root;
        public BinarySearchTree()
        {
            root = null;
        }

        public void Add(int i)
        {
            Node<T> newNode = new Node<T>();
            newNode.Data = i;
            if (root == null)
            {
                root = newNode;
                size++;
            }
            else
            {
                Node<T> current = root;
                Node<T> parent;
                while(true)
                {
                    parent = current;
                    if (i < current.Data)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            size++;
                            return;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            size++;
                            break;
                        }
                    }
                }
            }
        }
        public void sizeOfTree()
        {
            if(root == null)
            {
                Console.WriteLine("Binary Search Tree Is Empty");
            }
            Console.WriteLine("\nSize Of Tree Is: "+size++);
        }

        public void searchingTree(Node<T> newNode, int values)
        {
            if(newNode == null)
            {
                Console.WriteLine("{0} Is Not Present In Binary Search Tree", values);
            }
            else if(newNode.Data == values)
            {
                Console.WriteLine("{0} Is Present In Binary Search Tree",values);
            }
            else if(values < newNode.Data)
            {
                searchingTree(newNode.Left, values);
            }
            else
            {
                searchingTree(newNode.Right, values);
            }
        }

        public void Traversal(Node<T> Root)
        {
            if(Root != null)
            {
                Traversal(Root.Left);
                Console.WriteLine(Root.Data+" ");
                Traversal(Root.Right);
            }
        }
    }
}
