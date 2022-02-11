using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSProgram
{
    public class ChkPrNumAgPalProgram
    {
        //Method to check prime number that is anagram or palindrome
        public static void ChkPrNumAgPal()
        {
            //Initializing variables and list object
            Console.WriteLine("Finding The Prime Numbers That Are Anagram And Palindrome\n");
            int checkNum = 0;
            List<string> primeAgOrPal = new List<string>();
            
            //Taking the range from the user
            Console.Write("Enter The End Range Of Number : ");
            int endRange = int.Parse(Console.ReadLine());
            //Adding and checking the given numbers in range that are prime in the list
            Console.WriteLine("The prime number which are palindrome : ");
            while (checkNum <= endRange)
            {
                bool resPrime = Perform.IsPrime(checkNum);
                if (resPrime)
                {
                    primeAgOrPal.Add(Convert.ToString(checkNum));
                    if (Perform.IsPalindrome(checkNum))
                        Console.WriteLine(checkNum);
                }
                checkNum++;
            }
            Console.WriteLine();

            //Checking the prime numbers that are anagrams from the list
            Console.WriteLine("The Prime Number which are anagram : ");
            do
            {
                string str1 = primeAgOrPal[0];
                for (int i = 1; i < primeAgOrPal.Count; i++)
                {
                    string str2 = primeAgOrPal[i];
                    if (Perform.IsAnagram(str1, str2))
                        Console.WriteLine("{0} & {1}", str1, str2+" : are anagram of each other");
                }
                primeAgOrPal.RemoveAt(0);
            } while (primeAgOrPal.Count != 0);
        }
    }
}
