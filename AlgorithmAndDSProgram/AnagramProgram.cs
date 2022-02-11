using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSProgram
{
    public class AnagramProgram
    {
        //Method to check given strings are anagram or not
        public static void AnagramDetection()
        {
            Console.WriteLine("Anagram Detection Program\n");
            Console.Write("Enter the first string : ");
            string firstStr = Console.ReadLine();
            Console.Write("Enter the second string : ");
            string secStr = Console.ReadLine();

            //Calling the anagram detection method comparing two string
            if (Perform.IsAnagram(firstStr, secStr) == true)
                Console.WriteLine("The Given Strings Are Anagram\n");
            else
                Console.WriteLine("The Given Strings Are Not Anagram\n");
        }
    }
}
