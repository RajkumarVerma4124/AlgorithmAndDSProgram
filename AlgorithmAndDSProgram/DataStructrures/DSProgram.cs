using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmAndDSProgram;

namespace AlgorithmAndDSProgram.DataStructrures
{
    public class DSProgram
    {
        public static void DataStructure()
        {
            //Calling the method to read and write file data into unorder or order list
            while(true)
            {
                Console.WriteLine("\n1: Read String File And Add Into Unorderd List \n2: Read String Of Numbres File And Add Into Ordered List In Integer Format \n3: Simple Balance Paranthesis Program "+
                                  "\n4: Banking Cash Counter \n5: Palindrome Checker \n6: Hashing Function \n7: Number Of Binary Search Tree \n8: Prime Number Using 2D Array \n9: Extend Prime Number That Are Anagram Using 2D Array"+
                                  "\n10: Check Prime Number That Are Anagram Using Stack \n11: Check Prime Number That Are Anagram Using Queue \n12: Calender Program \n13: Go Back");
                Console.Write("Enter a choice from above : ");
                bool flag = int.TryParse(Console.ReadLine(), out int choice);
                if(flag)
                {
                    switch (choice)
                    {
                        case 1:
                            //Method to read strings and add into unordered list
                            ReadTextFile.ReadStringFile();
                            break;
                        case 2:
                            //Method to read integers and add into ordered list
                            ReadIntegerFile.ReadIntFile();
                            break;
                        case 3:
                            //Method to call simple balance paranthesis program
                            SimpleBalParenthesis.SimpleBalance();
                            break;
                        case 4:
                            //Method to call banking cash counter program
                            SimulateBanking.CashCounter();
                            break;
                        case 5:
                            //Method to check given string is palindrome or not
                            if(PalindromeChecker.IsPalindrome())
                                Console.WriteLine("It is palindrome");
                            else
                                Console.WriteLine("It is not palindrome");
                            break;
                        case 6:
                            //Method to add slots to numbers
                            HashSlots<int> hashSlots = new HashSlots<int>(11);
                            HashingNumber.NumberSlot(hashSlots);
                            break;
                        case 7:
                            //Method to find number of unique trees
                            Console.Write("Enter the number : ");
                            int numBin = int.Parse(Console.ReadLine());
                            Console.Write("Number of structurally Unique BST with {0} keys are : {1}",numBin, BinarySearchTree.NumberOfTree(numBin));
                            break;
                        case 8:
                            //Method to print prime number using 2d array
                            PrimeNumber2DProgram.PrintPrimeNumber();
                            break;
                        case 9:
                            //Method to extend prime number that are anagram using 2d array
                            PrimeNumAnagramProgram.PrimeNumAg();
                            break;
                        case 10:
                            //Method to extend prime number that are anagram using stack
                            PrimeNumAgStack.PrintPrimeAg();
                            break;
                        case 11:
                            //Method to extend prime number that are anagram using queue
                            PrimeNumAgQueue.PrintPrimeAg();
                            break;
                        case 12:
                            CalenderProgram.Calender();
                            break;
                        case 13:
                            Program.Main(null);
                            break;
                        default:
                            Console.WriteLine("Wrong Choice");
                            continue;
                    }
                }
                else
                    Console.WriteLine("Please Enter Some Choice");
            }
        }
    }
}
