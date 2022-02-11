using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSProgram
{
    /// <summary>
    /// Insertion sort algorithm to store strings in sorted order
    /// </summary>
    public class InsertionSortProgram
    {
        //Method to take string from the user and add it to the insertion sort
        public static void InsertionSort()
        {
            Console.WriteLine("Insertion Sort Program To Read Strings\n");
            Console.Write("Enter A Sentence Of Words : ");
            string strLine = Console.ReadLine();
            string[] strWord = strLine.Split(' ');
            int strLen = strWord.Length - 1;

            //Performing the sort of string array using insertion sort and printing it
            Perform.ISort(strWord);
            Console.Write("The values after performing insertion sort are : ");
            Perform.PrintArray(strWord, strLen);

        }
    }
}
