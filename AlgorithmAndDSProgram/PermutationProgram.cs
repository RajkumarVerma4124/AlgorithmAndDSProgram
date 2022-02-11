using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSProgram
{
    /// <summary>
    /// String permutation program
    /// </summary>
    public class PermutationProgram
    {
        //Method to performing the string permutation using string permutat
        public static void StringPermute()
        {
            Console.WriteLine("String Permutation Program\n");
            Console.Write("Enter first string : ");
            string permFirstStr = Console.ReadLine();
            Console.WriteLine("The permutation of the given string : {0}", permFirstStr);
            Perform.StringPermutation(permFirstStr, 0, permFirstStr.Length - 1);
            Console.ReadLine();

            //Check if arrays return by two string is equal or not
            Console.WriteLine("Array Return by two string are equal or not\n");
            Console.Write("Enter First String : ");
            string firstString = Console.ReadLine();
            Console.Write("Enter Second String : ");
            string secondString = Console.ReadLine();

            //Converting the string to char array
            char[] charsOne = firstString.ToCharArray();
            char[] charsTwo = secondString.ToCharArray();
            
            //Cheking the arrays return by two strings are equal or not
            if (Perform.CheckTwoStrings(charsOne, charsTwo))
                Console.WriteLine("Strings are equal\n");
            else
                Console.WriteLine("Strings are not equal\n");
        }
    }
}
