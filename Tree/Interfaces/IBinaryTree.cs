using System.Collections.Generic;

namespace Tree.Interfaces
{
    public interface IBinaryTree
    {
        ITreeNode Root { get; }
        void InsertNode(int value);
        void PostOrder(ITreeNode treeNode, List<int> output);
    }
}