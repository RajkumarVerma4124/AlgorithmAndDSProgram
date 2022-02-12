using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSProgram.DataStructrures
{
    public class PrimeNumAgStack
    {
        public static void PrintPrimeAg()
        {
            Console.WriteLine("Prime mumber anagram using stack program");

            //Creating the stack object to add anagrams
            StackLinkList<int> stackListOne = new StackLinkList<int>();
            StackLinkList<int> stackListTwo = new StackLinkList<int>();

            //Adding the prime number in the array
            int count = 0, tempCount = 0;
            string[] primeNumber = new string[200];
            while (count <= 1000)
            {
                bool result = Perform.IsPrime(count);
                if (result)
                {
                    primeNumber[tempCount] = count+"";
                    tempCount++;
                }
                count++;
            }
            Console.WriteLine();

            //Checking the prime numbers that are anagrams
            count = 0;
            while(count != tempCount)
            {
                string strPrimeOne = primeNumber[count];
                for (int i = count + 1; i < tempCount; i++)
                {
                    string strPrimeTwo = primeNumber[i];
                    if (Perform.IsAnagram(strPrimeOne, strPrimeTwo))
                    {
                        stackListOne.Push(Convert.ToInt32(strPrimeOne));
                        stackListTwo.Push(Convert.ToInt32(strPrimeTwo));
                    }
                }
                count++;
            }

            //Printing the prime numbers 
            Console.WriteLine("\nThe prime number that are anagram In reverse using stack\n");
            stackListOne.Display();
            stackListTwo.Display();
        }
    }
}
