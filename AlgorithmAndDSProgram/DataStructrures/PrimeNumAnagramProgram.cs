using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSProgram.DataStructrures
{
    public class PrimeNumAnagramProgram
    {
        //Method to print prime numbers that are anagram using 2d array
        public static void PrimeNumAg()
        {
            //Initializing the variables and array;
            Console.WriteLine("Prime number that are anagram in 2d array\n");
            int checkPrime = 0, tempCount = 0;
            bool result;
            string[] primeNumber = new string[200];
            
            //Storing the prime number from 0-1000 in string array
            while (checkPrime <= 1000)
            {
                result = Perform.IsPrime(checkPrime);
                if (result)
                {
                    primeNumber[tempCount] = checkPrime.ToString();
                    tempCount++;
                }
                checkPrime++;
            }
            Console.WriteLine();

            //Declaring and initializing variables and arrays and 2d arrayfor checking anagram
            int anagramCount = 0, nonAnagramCount = 0;
            checkPrime = 0;
            int[] anagram = new int[tempCount];
            int[] nonAnagram = new int[tempCount];
            string strPrimeTwo;
            int[][] anagramOrNonAnagram = new int[2][];

            //Checking the prime numbers that are anagram and stored it in array
            while(checkPrime != tempCount)
            {
                result = false;
                string strPrimeOne = primeNumber[checkPrime];
                for (int i = checkPrime+1; i < tempCount; i++)
                {
                    strPrimeTwo = primeNumber[i];
                    if (Perform.IsAnagram(strPrimeOne, strPrimeTwo))
                    {
                        result = true;
                        break;
                    }
                }
                if (result)
                {
                    anagram[anagramCount] = Convert.ToInt32(strPrimeOne);
                    anagramCount++;
                }
                else
                {
                    nonAnagram[nonAnagramCount] = Convert.ToInt32(strPrimeOne);
                    nonAnagramCount++;
                }
                checkPrime++;
            }

            //Initializing the array for both anagram and not anagram
            anagramOrNonAnagram[0] = new int[anagramCount];
            anagramOrNonAnagram[1] = new int[nonAnagramCount];

            //Storing the anagram and not anagram in 2d array and printing it
            for (int i = 0; i < anagramOrNonAnagram.Length; i++)
            {
                for (int j = 0; j < anagramOrNonAnagram[i].Length; j++)
                {
                    if (i == 0)
                        anagramOrNonAnagram[i][j] = anagram[j];
                    else
                        anagramOrNonAnagram[i][j] = nonAnagram[j];
                    Console.Write(anagramOrNonAnagram[i][j]+" ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
