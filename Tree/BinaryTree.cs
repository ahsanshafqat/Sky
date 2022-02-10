using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.Interfaces;

namespace Tree
{
    [Serializable()]
    public class BinaryTree : IBinaryTree
    {
        public ITreeNode Root { get; private set; }

        public void SetRoot(ITreeNode treeNode)
        {
            this.Root = treeNode;
        }

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

        public void PostOrder(ITreeNode treeNode, List<int> output)
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
