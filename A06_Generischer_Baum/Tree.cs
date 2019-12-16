using System;
using System.Collections;
using System.Collections.Generic;

namespace A06_Generischer_Baum
{
    class Tree<T>
    {
        public TreeNode createNode(T value)
        {
            return new TreeNode(value);
        }

        public void printTree(TreeNode node, string indent = "")
        {
            string output = node.ToString();
            Console.WriteLine(indent + output);
            indent += "*";

            foreach (var child in node.children)
            {
                this.printTree(child, indent);
            }
        }

        public class TreeNode: IEnumerable<TreeNode>
        {
            public delegate void EventHandler();
            public T value;
            public TreeNode parent;
            public List<TreeNode> children;
            private Dictionary<string, EventHandler> listeners;

            public TreeNode(T value)
            {
                this.value = value;
                this.parent = null;
                this.children = new List<TreeNode>{};
                this.listeners = new Dictionary<string, EventHandler>{};
            }

            public void appendChild(TreeNode child)
            {
                if(child.parent != null)
                    child.parent.removeChild(child);

                this.children.Add(child);
                child.parent = this;

                if (listeners.ContainsKey("AppendChild"))
                {
                    EventHandler handler = listeners["AppendChild"];
                    handler();
                }
            }

            public void removeChild(TreeNode child)
            {
                child.parent = null;
                this.children.Remove(child);

                if (listeners.ContainsKey("RemoveChild"))
                {
                    EventHandler listener = listeners["RemoveChild"];
                    listener();
                }
            }

            override public string ToString()
            {
                return value.ToString();
            }

            public void ForEach(Action<TreeNode> func)
            {
                func(this);
                
                foreach (var child in children)
                {
                    child.ForEach(func);
                }
            }

            public TreeNode FindRoot()
            {
                if (parent == null)
                    return this;
                else
                    return parent.FindRoot();
            }

            public void AddListener(string listenerType, EventHandler handler)
            {
                if (listeners.ContainsKey(listenerType))
                {
                    Console.WriteLine("Added another handler to " + listenerType + ".");
                    listeners[listenerType] += handler;
                }
                else
                {
                    Console.WriteLine("Added a first handler to " + listenerType + ".");
                    listeners.Add(listenerType, handler);
                }
            }

            public void RemoveListener(string type, EventHandler handler)
            {
                if (listeners.ContainsKey(type))
                {
                    if (listeners[type].Method == handler.Method)
                    {
                        Console.WriteLine("Removing handler from " + type + ".");
                        listeners[type] -= handler;
                    }                    
                }
            }

            public IEnumerator<TreeNode> GetEnumerator()
            {
                yield return this;
                foreach (var childNode in this.children)
                    foreach(var child in childNode)
                        yield return child; 
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}
