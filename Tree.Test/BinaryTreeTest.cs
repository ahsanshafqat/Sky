using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Tree.Extensions;
using Xunit;

namespace Tree.Test
{
    public class BinaryTreeTest
    {
        private readonly BinaryTree binaryTree;
        private const int FirstValue = 5;
        
        public BinaryTreeTest()
        {
            binaryTree = new BinaryTree();
        }

        [Fact]
        public void Insert_With_No_TreeNodes_Should_Insert_FirstNode_As_Root_Node()
        {
            binaryTree.InsertNode(FirstValue);
            binaryTree.Root.Should().NotBeNull();
            binaryTree.Root.Value.Should().Be(FirstValue);
        }

        [Theory]
        [InlineData(3)]
        public void Insert_NumberSmallerThanFirstValue_ShouldSetLeftChild(int childValue)
        {
            binaryTree.InsertNode(FirstValue);
            binaryTree.InsertNode(childValue);

            binaryTree.Root.LeftChild.Should().NotBeNull();
            binaryTree.Root.RightChild.Should().BeNull();
            binaryTree.Root.LeftChild.Value.Should().Be(childValue);
        }

        [Theory]
        [InlineData(7)]
        public void Insert_NumberGreaterThanFirstValue_ShouldSetRightChild(int childValue)
        {
            binaryTree.InsertNode(FirstValue);
            binaryTree.InsertNode(childValue);

            binaryTree.Root.RightChild.Should().NotBeNull();
            binaryTree.Root.LeftChild.Should().BeNull();
            binaryTree.Root.RightChild.Value.Should().Be(childValue);
        }
        [Fact]
        
        public void Insert_NumberGreaterThanFirstValue_AndNumberSmallerThanFirstValue_ShouldSet_Left_And_Right_Child()
        {
            binaryTree.InsertNode(FirstValue);
            binaryTree.InsertNode(3);
            binaryTree.InsertNode(7);

            binaryTree.Root.LeftChild.Should().NotBeNull();
            binaryTree.Root.LeftChild.Value.Should().Be(3);

            binaryTree.Root.RightChild.Should().NotBeNull();
            binaryTree.Root.RightChild.Value.Should().Be(7);
        }

        [Fact]
        public void Pars_Tree_Should_BuildTree_With_Post_Order_Output()
        {
            string inputString = "15,10,22,4,12,18,24";

            string[] input = inputString.Split(',');

            for (int i = 0; i < input.Length; i++)
            {
                int value = Convert.ToInt32(input[i]);
                binaryTree.InsertNode(value);
            }

            var nodes = new List<int>();

            binaryTree.PostOrder(binaryTree.Root, nodes);

            string output = StringExtensions.Join(",", nodes);

            output.Should().Be("4,12,10,18,24,22,15");
        }
    }
}
