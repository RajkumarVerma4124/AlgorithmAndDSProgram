using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSProgram
{
    public class BubbleSortProgram
    {
        public static void BubbleSort()
        {
            Console.WriteLine("Bubble Sort Program To Sort Integers\n");
            Console.Write("Enter numbers in a single line using spaces like 10 20 30: ");
            string num = Console.ReadLine();
            string[] strNum = num.Split(' ');
            int[] numArr = new int[strNum.Length];
            for (int i = 0; i < strNum.Length; i++)
            {
                numArr[i] = int.Parse(strNum[i]);
            }
            Perform.BSort(numArr);
            Console.Write("The numbers after performing bubble sort are : ");
            Perform.PrintArray(numArr, numArr.Length - 1);
        }
    }
}
