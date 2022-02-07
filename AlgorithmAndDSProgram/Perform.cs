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

        //Generics method of binary search for different datatype 
        public static bool BinarySearch<T>(T[] list, T search) where T : IComparable
        {
            int startPos = 0;
            int endPos = list.Length - 1;
            while (startPos <= endPos)
            {
                int midLen = startPos + (endPos - startPos) / 2;
                int result = search.CompareTo(list[midLen]);

                //Checking If the string is present at the middle 
                if (result == 0)
                    return true;

                // If string is greater, ignore left half
                if (result > 0)
                    startPos = midLen + 1;
                else
                    // If string is smaller, ignore right half
                    endPos = midLen - 1;
            }

            return false;
        }
    }
}
