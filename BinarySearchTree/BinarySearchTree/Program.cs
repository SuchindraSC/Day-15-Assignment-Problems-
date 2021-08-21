using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nBINARY SEARCH TREE (BST)");

            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();

            //USE CASE 1 AND 2
            Console.WriteLine("\nUSE CASE 1 & 2");
            Console.WriteLine("\nRoot Of This BST Is : 56");
            binarySearchTree.Add(56);
            binarySearchTree.Add(30);
            binarySearchTree.Add(70);
            binarySearchTree.Add(22);
            binarySearchTree.Add(40);
            binarySearchTree.Add(60);
            binarySearchTree.Add(95);
            binarySearchTree.Add(11);
            binarySearchTree.Add(65);
            binarySearchTree.Add(3);
            binarySearchTree.Add(16);
            binarySearchTree.Add(63);
            binarySearchTree.Add(67);

            Console.WriteLine("Binary Search Tree Traversal");
            binarySearchTree.Traversal(binarySearchTree.root);
            binarySearchTree.sizeOfTree();


            //USE CASE 3
            Console.WriteLine("\n\nUSE CASE 3");
            Console.WriteLine("\nSearching Whether Root 63 Is Present In Binary Search Tree Or Not ==>");
            binarySearchTree.searchingTree(binarySearchTree.root, 63);
        }
    }
}
