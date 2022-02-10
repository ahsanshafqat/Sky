using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.Interfaces;
using Xunit;

namespace Tree.Test
{
    public class TextFileWriterTest
    {
        private readonly BinaryTree binaryTree;
        private const int FirstValue = 5;

        public TextFileWriterTest()
        {
            binaryTree = new BinaryTree();
        }
        [Fact]
        public void Test_Tree_Writen_To_File_Is_Same_When_Read_From_File()
        {
            binaryTree.InsertNode(FirstValue);
            binaryTree.InsertNode(3);
            binaryTree.InsertNode(7);

            ITextFileWriter textFileWriter = new TextFileWriter();

            textFileWriter.Write("SkyTreeTest.txt", binaryTree.Root);

            ITextFileReader textFileReader = new TextFileReader();

            ITreeNode treeNode = textFileReader.Read("SkyTreeTest.txt");    

            treeNode.Value.Should().Be(5);

            treeNode.LeftChild.Should().NotBeNull();
            treeNode.LeftChild.Value.Should().Be(3);

            treeNode.RightChild.Should().NotBeNull();
            treeNode.RightChild.Value.Should().Be(7);

        }

    }
}
