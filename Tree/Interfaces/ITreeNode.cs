namespace Tree.Interfaces
{
    public interface ITreeNode
    {
        TreeNode LeftChild { get; set; }
        TreeNode RightChild { get; set; }
        int Value { get; }
    }
}