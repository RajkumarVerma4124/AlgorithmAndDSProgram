using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmAndDSProgram.DataStructrures;

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

        //Method to Sort the array of string according to lengths by implementing insertion sort
        public static void ISort<T>(T[] arrGen) where T : IComparable
        {
            int arrLen = arrGen.Length;
            for (int i = 1; i < arrLen; ++i)
            {
                T temp = arrGen[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], that are greater than key to one position ahead of their current position
                while (j >= 0 && arrGen[j].CompareTo(temp) > 0)
                {
                    arrGen[j + 1] = arrGen[j];
                    j--;
                }
                arrGen[j + 1] = temp;
            }
        }


        //Method to sort numbers using bubble sort
        public static void BSort<T>(T[] arr) where T : IComparable
        {
            int arrLen = arr.Length;
            for (int i = 0; i < arrLen - 1; i++)
                for (int j = 0; j < arrLen - i - 1; j++)
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        // swap temp and arr[i] 
                        T temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }

        //Method to merging two subarrays of []arr first subarray is arr[firstPos..midLen Second subarray is arr[midLen+1..endPos]
        public static void MSort<T>(T[] arr, int firstPos, int midLen, int endPos) where T : IComparable
        {
            // Finding the sizes of two subarrays to be merged
            int sizeArrOne = midLen - firstPos + 1;
            int sizeArrTwo = endPos - midLen;

            // Creating temp arrays
            T[] leftArr = new T[sizeArrOne];
            T[] rightArr = new T[sizeArrTwo];

            //Declaring local variables
            int i, j;

            // Copying data to temp arrays
            for (i = 0; i < sizeArrOne; ++i)
                leftArr[i] = arr[firstPos + i];
            for (j = 0; j < sizeArrTwo; ++j)
                rightArr[j] = arr[midLen + 1 + j];

            // Initializing indexes of first and second subarrays
            i = 0;
            j = 0;

            //Initializing index of merge subarray array
            int k = firstPos;
            while (i < sizeArrOne && j < sizeArrTwo)
            {
                if (leftArr[i].CompareTo(rightArr[j]) <= 0)
                {
                    arr[k] = leftArr[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArr[j];
                    j++;
                }
                k++;
            }

            // Copying remaining elements of leftArray[] if any
            while (i < sizeArrOne)
            {
                arr[k] = leftArr[i];
                i++;
                k++;
            }

            // Copying remaining elements of rightArray[] if any
            while (j < sizeArrTwo)
            {
                arr[k] = rightArr[j];
                j++;
                k++;
            }
        }

        //Method to recursively sorts two array merge them to produce a sorted array
        public static void Sort<T>(T[] arr, int firstPos, int endPos) where T : IComparable
        {
            if (firstPos < endPos)
            {
                // Finding the middle point to divide array into two havles
                int midLen = firstPos + (endPos - firstPos) / 2;

                //Sorting first and second halves
                Sort(arr, firstPos, midLen);
                Sort(arr, midLen + 1, endPos);

                // Merging the sorted halves
                Perform.MSort(arr, firstPos, midLen, endPos);
            }
        }

        //Method to check whether given two strings are anagram of each other
        public static bool IsAnagram(string firstStr, string secStr)
        {
            //Checking the length of the string
            if (firstStr.Length != secStr.Length)
                return false;

            //Converting the string to charArray
            char[] firstChar = firstStr.ToLower().ToCharArray();
            char[] secChar = secStr.ToLower().ToCharArray();

            //Sorting the character array
            Array.Sort(firstChar);
            Array.Sort(secChar);

            //Checking each character and position
            for (int i = 0; i < firstChar.Length; i++)
            {
                if (firstChar[i] != secChar[i])
                    return false;
            }
            return true;
        }

        //Method to print the prime numbers in the given range
        public static int PrintPrimeNum(int startNum, int endNum)
        {
            Console.WriteLine("Prime numbers between " + startNum + " and " + endNum + " are : ");
            int count;
            //loop for finding and printing all prime numbers between given range
            for (int i = startNum; i <= endNum; i++)
            {
                //logic for checking number is prime or not
                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        count++;
                }
                if (count == 2)
                    Console.Write(i + " : ");
            }
            Console.WriteLine();
            return default;
        }

        //Checking If Given Number Is Prime Number Or Not
        public static bool IsPrime(int pNum)
        {
            if (pNum == 0 || pNum == 1)
                return false;
            for (int i = 2; i < pNum; i++)
            {
                if (pNum % i == 0)
                    return false;
            }
            return true;
        }

        //Checking a given number is palindrome or not
        public static bool IsPalindrome(int palNum)
        {
            if (palNum < 10)
                return false;
            //Converting integer to string
            string numStr = Convert.ToString(palNum);
            //Converting string to char array
            char[] numArr = numStr.ToCharArray();
            string tempStr = string.Empty;
            //Reversing the string
            for (int i = numArr.Length - 1; i >= 0; i--)
            {
                // Append each character to the temp string.
                tempStr += numArr[i];
            }
            if (tempStr.Equals(numStr))
                return true;
            else
                return false;
        }

        //Method to perform stack operation for simple balance program
        public static bool CheckParentheses(string parStr)
        {
            StackProgram<char> stack = new StackProgram<char>();

            char[] parChar = parStr.ToCharArray();

            for (int i = 0; i < parStr.Length; i++)
            {
                if (parChar[i] == '(')
                    stack.Push(parChar[i]);
                else if (parChar[i] == ')')
                    stack.Pop();
            }

            if (stack.IsEmpty())
                return true;
            else
                return false;
        }

        //Method to print an array
        public static void PrintArray<T>(T[] str, int len)
        {
            for (int i = 0; i <= len; i++)
                Console.Write(str[i] + " ");
            Console.WriteLine();
        }
    }
}
