using System;
using System.Collections.Generic;

namespace A06_Generischer_Baum
{
    class TreeNode
    {
        public TreeNode Parent;
        public List<TreeNode> Children;

        public TreeNode(TreeNode parent, List<TreeNode> children) {

            this.Parent = parent;
            this.Children = children;
        }
    }
}
