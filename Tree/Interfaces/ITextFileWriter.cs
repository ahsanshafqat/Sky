namespace Tree.Interfaces
{
    public interface ITextFileWriter
    {
        void Write(string fileName, ITreeNode tree);
    }
}