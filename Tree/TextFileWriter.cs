using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Tree.Interfaces;

namespace Tree
{
    public class TextFileWriter : ITextFileWriter
    {
        public void Write(string fileName, ITreeNode tree)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);

            binaryFormatter.Serialize(fileStream, tree);

            fileStream.Close();
        }
    }
}
