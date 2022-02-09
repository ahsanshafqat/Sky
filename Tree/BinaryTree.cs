using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class BinaryTree
    {
        public TreeNode Root { get; private set; }

        public void InsertNode(int value)
        {
            if (Root == null)
            {
                Root = new TreeNode(value);
                return;
            }

            var newNode = new TreeNode(value);

            var current = Root;

            while (true)
            {
                var parent = current;

                if (value < current.Value)
                {
                    current = current.LeftChild;

                    if (current == null)
                    {
                        parent.LeftChild = newNode;
                        return;
                    }
                }
                else
                {
                    current = current.RightChild;

                    if (current == null)
                    {
                        parent.RightChild = newNode;
                        return;
                    }
                }

            }
        }

        //public void PreOrder(TreeNode treeNode, List<int> output)
        //{
        //    if (Root == null)
        //        return;

        //    if (treeNode != null)
        //    {
        //        PreOrder(treeNode.LeftChild, output);

        //        PreOrder(treeNode.RightChild, output);

        //        output.Add(treeNode.Value);

        //    }
        //}

        public void PostOrder(TreeNode treeNode, List<int> output)
        {
            if (Root == null)
                return;

            if (treeNode != null)
            {
                PostOrder(treeNode.LeftChild, output);

                PostOrder(treeNode.RightChild, output);

                output.Add(treeNode.Value);

            }
        }
    }
}
