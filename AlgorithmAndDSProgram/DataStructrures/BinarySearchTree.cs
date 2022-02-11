using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace AlgorithmAndDSProgram.DataStructrures
{
    public class BinarySearchTree
    {
        //Method to find number of binary search tree
        public static double NumberOfTree(int data)
        {
            Console.WriteLine("Binary Search Tree Program\n");
            int[] uniqueBST = new int[data + 1];
            uniqueBST[0] = 1;
            uniqueBST[1] = 1;
            for (int i = 2; i <= data; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    uniqueBST[i] = uniqueBST[i - j] * uniqueBST[j - 1] + uniqueBST[i];
                }
            }
            double powerVal = Math.Pow(10, 8)+7;
            return Math.Abs(uniqueBST[data] % powerVal);
        }
    }
}
