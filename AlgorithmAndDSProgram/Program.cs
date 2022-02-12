using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmAndDSProgram.DataStructrures;

namespace AlgorithmAndDSProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Displaying welcome message
            Console.WriteLine("Welcome to the data structure and algorithm programs");

            while (true)
            {
                Console.WriteLine("1: String Permutation \n2: Binary String Search \n3: Insertion Sort \n4: Bubble Sort \n5: Merge Sort \n6: Anagram Detection \n7: Print Prime Numbers" +
                                "\n8: Check Prime Number i.e Angaram and Palindrome \n9: Find The Guessing Number \n10: Customize Message \n11: Data Structures \n12: Exit");
                Console.Write("Enter a choice from above : ");
                bool flag = int.TryParse(Console.ReadLine(), out int choice);
                if(flag)
                {
                    switch (choice)
                    {
                        case 1:
                            //Calling the string permutation method to prmute string
                            PermutationProgram.StringPermute();
                            //Callingthe string permutation method to compare two strings array
                            PermutationProgram.TwoStringArray();
                            break;
                        case 2:
                            //Calling the binary search string method
                            BinarySearchProgram.BinarySearchWord();
                            break;
                        case 3:
                            //Calling the isertion sort string method
                            InsertionSortProgram.InsertionSort();
                            break;
                        case 4:
                            //Calling the bubble sort string method
                            BubbleSortProgram.BubbleSort();
                            break;
                        case 5:
                            //Calling the merge sort string method
                            MergeSortProgram.MergeSort();
                            break;
                        case 6:
                            //Calling the anagram detection method
                            AnagramProgram.AnagramDetection();
                            break;
                        case 7:
                            //Calling the print prime number method
                            PrimeNumberProgram.PrimeNumbers();
                            break;
                        case 8:
                            //Calling the method to check prime number i.e anagram and palindrome
                            ChkPrNumAgPalProgram.ChkPrNumAgPal();
                            break;
                        case 9:
                            //Calling the method to guess the number
                            FindNumberProgram.GuessNumber();
                            break;
                        case 10:
                            //Calling the customize message method
                            CustomizeMessageProgram.PrintMessage();
                            break;
                        case 11:
                            //Calling the data structure method
                            DSProgram.DataStructure();
                            break;
                        case 12:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Wrong choice");
                            continue;
                    }
                }
                else
                    Console.WriteLine("Please enter some choice");
            }
        }
    }
}
