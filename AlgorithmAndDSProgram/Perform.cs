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

        //Method to print an array
        public static void PrintArray<T>(T[] str, int len)
        {
            for (int i = 0; i <= len; i++)
                Console.Write(str[i] + " ");
            Console.WriteLine();
        }
    }
}
