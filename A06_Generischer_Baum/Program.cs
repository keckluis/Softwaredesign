using System;
using System.Collections.Generic;

namespace A06_Generischer_Baum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var tree = new TreeNode<String>("tree");

            var root = tree.createNode("root");
            var child1 = tree.createNode("child1");
            var child2 = tree.createNode("child2");

            root.appendChild(child1);
            root.appendChild(child2);

            var grand11 = tree.createNode("grand11");
            var grand12 = tree.createNode("grand12");
            var grand13 = tree.createNode("grand13");

            child1.appendChild(grand11);
            child1.appendChild(grand12);
            child1.appendChild(grand13);

            var grand21 = tree.createNode("grand21");
            
            child2.appendChild(grand21);
            child1.removeChild(grand12);

            root.printTree(); 

            root.ForEach(Func<string>);
        }

        static void Func<T>(TreeNode<T> node)
        {
            Console.Write(node.value + " | ");
        }
    }
}