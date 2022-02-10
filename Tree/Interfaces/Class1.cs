using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class TextFileReader : ITextFileReader
    {
        public ITreeNode Read(string fileName)
        {
            BinaryFormatter bin = new BinaryFormatter();

            IBinaryTree binaryTree = new BinaryTree();

            FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);

            ITreeNode treeNode = (ITreeNode)bin.Deserialize(fileStream);

            fileStream.Close();

            return treeNode;
        }
    }
}
