namespace Tree.Interfaces
{
    public interface ITextFileReader
    {
        ITreeNode Read(string fileName);
    }
}