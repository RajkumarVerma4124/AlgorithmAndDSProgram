using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSProgram
{
    public class PermutationProgram
    {
        //Performing the string permutation
        public static void StringPermuation()
        {
            Console.WriteLine("String Permutation Program\n");
            Console.Write("Enter a string : ");
            string permStr = Console.ReadLine();
            Console.WriteLine("The permutation of the given string : {0}", permStr);
            Perform.StringPermutation(permStr, 0, permStr.Length - 1);
            Console.ReadLine();
        }
    }
}
