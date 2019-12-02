using System;
using System.Collections.Generic;

namespace A06_Generischer_Baum
{
    class TreeNode<T>
    {
        public T value;
        public List<TreeNode<T>> children;

        public TreeNode()
        {
            this.children = new List<TreeNode<T>>();
        }

        public TreeNode(T value)
        {
            this.value = value;
            this.children = new List<TreeNode<T>>();
        }

        public TreeNode<T> createNode(T value)
        {
            return new TreeNode<T>(value);
        }

        public void appendChild(TreeNode<T> child)
        {
            children.Add(child);
        }

        public void removeChild(TreeNode<T> child)
        {
            children.Remove(child);
        }

        public void printTree()
        {
            Console.WriteLine(this.value);

            printChildren("", this);
        }

        private void printChildren(string gen, TreeNode<T> parent)
        {
            gen += "*";

            foreach (TreeNode<T> child in parent.children)
            {
                Console.WriteLine(gen + child.value.ToString());

                printChildren(gen, child);
            }
        }
    }
}
