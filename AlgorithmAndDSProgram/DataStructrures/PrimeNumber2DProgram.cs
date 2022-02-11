using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSProgram.DataStructrures
{
    public class PrimeNumber2DProgram
    {
        //Method to print prime numbers using 2d array
        public static void PrintPrimeNumber()
        {
            //Initializing 2d array, array, variables;
            Console.WriteLine("Prime number in 2d array\n");
            int[][] primeNumber = new int[10][];
            int[] tempPrime = new int[100];
            int min = 0, max = 100, oneDimCount = 0;
            int checkPrime = 0, tempCount = 0;
            bool resPrime;

            //Checking the number in a given range is prime or not from 0-100,100-200...etc and stored in 2d array
            Console.WriteLine("The Prime Number in the range of (0 - 1000) are: ");
            while (checkPrime <= 1000)
            {
                resPrime = Perform.IsPrime(checkPrime);
                if (resPrime)
                {
                    tempPrime[tempCount] = checkPrime;
                    if (checkPrime >= min && checkPrime <= max)
                        tempCount++;
                }
                if (checkPrime >= max)
                {
                    primeNumber[oneDimCount] = new int[tempCount];
                    for (int i = 0; i < tempCount; i++)
                        primeNumber[oneDimCount][i] = tempPrime[i];
                    oneDimCount++;
                    tempCount = 0;
                    min = max;
                    max += 100;
                }
                checkPrime++;
            }

            //Printing the 2d prime array
            for (int i = 0; i < primeNumber.Length; i++)
            {
                for (int j = 0; j < primeNumber[i].Length; j++)
                    Console.Write(primeNumber[i][j]+" ");
                Console.WriteLine();
            }
        }
    }
}
