using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.Extensions;
using Tree.Interfaces;

namespace Tree.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (args.Length > 0)
            {
                //Read input
                string[] input = args[0].Split(',');

                BinaryTree bTree = new BinaryTree();

                //Add tree nodes
                for (int i = 0; i < input.Length; i++)
                {
                    int value = Convert.ToInt32(input[i]);
                    bTree.InsertNode(value);
                }

                //Prepare output
                List<int> nodes = new List<int>();

                bTree.PostOrder(bTree.Root, nodes);

                string output = StringExtensions.Join(",", nodes);

                Console.WriteLine(output);

                //Write tree structure on file
                ITextFileWriter textFileWriter = new TextFileWriter();

                textFileWriter.Write("SkyTree.txt", bTree.Root);              

                Console.ReadKey();
            }
        }
    }
}
