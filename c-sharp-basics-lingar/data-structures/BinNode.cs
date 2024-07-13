using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.data_structures
{
    public class BinNode<T>
    {
        private T value;
        private BinNode<T> left;
        private BinNode<T> right;
        public BinNode(T value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }
        public BinNode(BinNode<T> left, T value, BinNode<T> right)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }
        public BinNode<T> getLeft()
        {
            return this.left;
        }
        public BinNode<T> getRight()
        {
            return this.right;
        }
        public void setLeft(BinNode<T> left)
        {
            this.left = left;
        }
        public void setRight(BinNode<T> right)
        {
            this.right = right;
        }
        public T getValue()
        {
            return this.value;
        }
        public void setValue(T value)
        {
            this.value = value;
        }
        public bool hasLeft()
        {
            return this.left != null;
        }
        public bool hasRight()
        {
            return this.right != null;
        }
        public String toString()
        {
            return " " + this.value;
        }
        public static void InOrderHelper(BinNode<T> node)
        {
            if (node == null)
            {
                return;
            }
            InOrderHelper(node.getLeft());
            Console.Write(node.getValue() + " ");
            InOrderHelper(node.getRight());
        }
    }
}
