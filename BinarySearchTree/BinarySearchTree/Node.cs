using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class Node<T> where T : IComparable
    {
        public int Data;
        public Node<T> Left;
        public Node<T> Right;
    }
}
