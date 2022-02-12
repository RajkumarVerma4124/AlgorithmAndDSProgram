using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSProgram.DataStructrures
{
    public class PrimeNumAgQueue
    {
        public static void PrintPrimeAg()
        {
            Console.WriteLine("Prime mumber anagram using queue program");
            //Creating the queue object to add anagrams

            QueueLinklist<int> queueOne = new QueueLinklist<int>();
            QueueLinklist<int> queueTwo = new QueueLinklist<int>();
            
            //Adding the prime number in the array
            int count = 0, tempCount = 0;
            string[] primeNumber = new string[200];
            while (count <= 1000)
            {
                bool result = Perform.IsPrime(count);
                if (result)
                {
                    primeNumber[tempCount] = count.ToString();
                    tempCount++;
                }
                count++;
            }
            Console.WriteLine();
            
            //Checking the prime numbers that are anagrams
            count = 0;
            while (count != tempCount)
            {
                string strPrimeOne = primeNumber[count];
                for (int i = count + 1; i < tempCount; i++)
                {
                    string strPrimeTwo = primeNumber[i];
                    if (Perform.IsAnagram(strPrimeOne, strPrimeTwo))
                    {
                        queueOne.Enqueue(int.Parse(strPrimeOne));
                        queueTwo.Enqueue(int.Parse(strPrimeTwo));
                    }
                }
                count++;
            }

            //Printing the prime numbers 
            Console.WriteLine("\nThe prime number that are anagram using queue\n");
            queueOne.Display();
            queueTwo.Display();       
        }
    }
}
