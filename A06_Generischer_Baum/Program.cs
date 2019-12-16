using System;
using System.Collections.Generic;

namespace A06_Generischer_Baum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var tree = new Tree<string>();

            var root = tree.createNode("root");

            root.AddListener("AppendChild", HandleAppendChild);
            root.AddListener("AppendChild", HandleAppendChild);

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

            tree.printTree(root); 

            root.ForEach(Func<string>);

            foreach (var child in root)
            {
                Console.WriteLine(child.value);
            }
        }

        static void Func<T>(Tree<T>.TreeNode node)
        {
            Console.Write(node.value + " | ");
        }

        static void HandleAppendChild()
        {
            Console.WriteLine("Child added");
        }
        static void HandleRemoveChild()
        {
            Console.WriteLine("Child removed");
        }
    }
}