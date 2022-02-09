using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.Extensions;

namespace Tree.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (args.Length > 0)
            {
                string[] input = args[0].Split(',');

                BinaryTree bTree = new BinaryTree();

                for (int i = 0; i < input.Length; i++)
                {
                    int value = Convert.ToInt32(input[i]);
                    bTree.InsertNode(value);
                }

                List<int> nodes = new List<int>();
                
                bTree.PostOrder(bTree.Root, nodes);

                string output = StringExtensions.Join(",", nodes);
                
                Console.WriteLine(output);

                Console.ReadKey();

            }


        }
    }
}
