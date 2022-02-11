using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSProgram
{
    /// <summary>
    /// Merge sort algorithm to store strings in sorted order
    /// </summary>
    public class MergeSortProgram
    {
        //Method to take the strings from user and sort it using merge sort method
        public static void MergeSort()
        {
            Console.WriteLine("Merge Sort Program To Sort Strings\n");
            Console.Write("Enter A Sentence Of Words : ");
            string strLine = Console.ReadLine();
            string[] strWord = strLine.Split(' ');

            //Printing the string before sorting
            Console.Write("Array Before Sorting : ");
            int strLen = strWord.Length - 1;
            Perform.PrintArray(strWord, strLen);

            //Printing the string after sorting using merge sort
            Perform.Sort(strWord, 0, strLen);
            Console.Write("The values after performing merge sort are : ");
            Perform.PrintArray(strWord, strLen);

        }
    }
}
