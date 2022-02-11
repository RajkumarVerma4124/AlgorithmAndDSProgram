 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSProgram.DataStructrures
{
    public class SimpleBalParenthesis
    {
        //Simple balance paranthesis 
        public static void SimpleBalance()
        {
            Console.WriteLine("Simple Balanced Parentheses Program\n");
            //Taking the arithmetic expression from the user
            Console.Write("Enter the Arithmetic Expression: ");
            string expStr = Console.ReadLine();

            //Checking the parenthesis from the express from left to right
            if(Perform.CheckParentheses(expStr))
                Console.WriteLine("The arithmetic expression are balanced");
            else
                Console.WriteLine("The arithmetic expression are not balanced");
        }
    }
}
