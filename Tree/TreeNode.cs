using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class TreeNode
    {
        public TreeNode(int value)
        {
            Value = value;
        }

        public int Value { get; }

        public TreeNode LeftChild { get; set; }

        public TreeNode RightChild { get; set; }
    }
}
