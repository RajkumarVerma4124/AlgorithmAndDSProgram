using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSProgram.DataStructrures
{
    public class SimpleBalParenthesis
    {
        public static void SimpleBalance()
        {
            Console.WriteLine("Simple Balanced Parentheses Program\n");
            Console.Write("Enter the Arithmetic Expression: ");
            string expStr = Console.ReadLine();

            if(Perform.CheckParentheses(expStr))
                Console.WriteLine("The arithmetic expression are balanced");
            else
                Console.WriteLine("The arithmetic expression are not balanced");
        }
    }
}
