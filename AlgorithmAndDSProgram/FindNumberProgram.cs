using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSProgram
{
    /// <summary>
    /// Guess to find your number
    /// </summary>
    public class FindNumberProgram
    {
        //Initialing the variables
        public static int firstNum = 0, lastNum = 100;
        public static bool foundNum = false;
        
        //Method to guess the number
        public static void GuessNumber()
        {
            Console.WriteLine($"Think a number between {firstNum} - {lastNum} ");
            while (foundNum == false)
            {
                int midValue = (firstNum + lastNum) / 2;
                CheckValue(midValue);
            }
        }

        //Method to check the guessed value and asked the user if its true
        public static void CheckValue(int midValue)
        {
            Console.WriteLine($"\nPress \n1: If your number is {midValue}\n2: If your number is low \n3: If your number is high");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You guessed it right the number is : {0}", midValue);
                    foundNum = true;
                    break;
                case 2:
                    foundNum = false;
                    lastNum = midValue - 1;
                    break;
                case 3:
                    foundNum = false;
                    firstNum = midValue + 1;
                    break;
            }
        }
    }
}
