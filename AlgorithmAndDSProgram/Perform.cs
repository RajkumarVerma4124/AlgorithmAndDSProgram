using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSProgram
{
    public class Perform
    {
        //Method to swap the characters of the string
        public static string Swap(string str, int start, int end)
        {
            char temp;
            char[] charArray = str.ToCharArray();
            temp = charArray[start];
            charArray[start] = charArray[end];
            charArray[end] = temp;
            string newStr = new string(charArray);
            return newStr;
        }

        //Method to perform the permutation of the String.
        public static void StringPermutation(string permStr, int start, int end)
        {
            if (start == end)
                Console.WriteLine(" "+permStr);
            else
            {
                for (int i = start; i <= end; i++)
                {
                    permStr = Swap(permStr, start, i);
                    StringPermutation(permStr, start + 1, end);
                    permStr = Swap(permStr, start, i);
                }
            }
        }
    }
}
