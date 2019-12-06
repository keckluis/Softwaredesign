using System;
using System.Collections.Generic;

namespace A06_Generischer_Baum
{
    class TreeNode<T>
    {
        public T value;
        public TreeNode<T> parent;
        public List<TreeNode<T>> children;

        public TreeNode(T value)
        {
            this.value = value;
            this.parent = null;
            this.children = new List<TreeNode<T>>();
        }

        public TreeNode<T> createNode(T value)
        {
            return new TreeNode<T>(value);
        }

        public void appendChild(TreeNode<T> child)
        {
            if(child.parent != null)
                child.parent.removeChild(child);

            this.children.Add(child);
            child.parent = this;
        }

        public void removeChild(TreeNode<T> child)
        {
            this.children.Remove(child);
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

        public void ForEach(Action<TreeNode<T>> func)
        {
            func(this);
            
            foreach (var child in children)
            {
                child.ForEach(func);
            }
        }
    }
}
