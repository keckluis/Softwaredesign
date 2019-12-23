using System;
using System.Collections.Generic;

namespace A06_Generischer_Baum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            TreeJsonLoader loader = new TreeJsonLoader();

            var root = loader.LoadJson("Tree.json");

            root.printTree(root); 

            //root.ForEach(Func<string>);

            // foreach(var child in root)
            // {
            //     Console.WriteLine(child.value);
            // }
        }

        static void Func<T>(Tree<T>.TreeNode node)
        {
            Console.Write(node.value + " | ");
        }

        static void HandleAppendChild()
        {
            Console.WriteLine("child added");
        }
        static void HandleRemoveChild()
        {
            Console.WriteLine("child removed");
        }
    }
}