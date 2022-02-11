using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSProgram.DataStructrures
{
    internal class PalindromeChecker
    {
        //Method to check the given string is palindrome or not
        public static bool IsPalindrome()
        {
            Console.WriteLine("Palindrome Checker Program");
            //Creating the char linklist using generics and object of linklist
            UnorderedList<char> isPal = new UnorderedList<char>();
            
            Console.Write("Enter a palindrome to get checked : ");
            string palStr = Console.ReadLine();
            char[] palChar = palStr.ToCharArray();
            
            //Adding the char data in the linklist in reverse order
            for(int i = 0; i < palChar.Length; i++)
                isPal.AddFirst(palChar[i]);

            //Removing the data in straight order
            string revStr=null;
            for (int i = 0; i < palChar.Length; i++)
                revStr+=isPal.DeleteLast();

            if (palStr.Equals(revStr))
                return true;
            else
                return false;
        }
    }
}
