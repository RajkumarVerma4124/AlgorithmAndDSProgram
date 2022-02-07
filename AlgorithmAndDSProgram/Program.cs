using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Displaying welcome message
            Console.WriteLine("Welcome to the data structure and algorithm programs");
            Console.ReadLine();

            while (true)
            {
                Console.WriteLine("1: String Permutation \n2: Binary String Search \n3: Insertion Sort \n4: Bubble Sort \n5: Exit");
                Console.Write("Enter a choice from above : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //Calling the string permutation method
                        PermutationProgram.StringPermuation();
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
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        continue;
                }
            }
        }
    }
}
