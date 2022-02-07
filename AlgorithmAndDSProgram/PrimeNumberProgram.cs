using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSProgram
{
    public class PrimeNumberProgram
    {
        public static void PrimeNumbers()
        {
            Console.WriteLine("Print Prime Numbers In A Given Range\n");
            Console.Write("Enter Starting Number : ");
            int startNum = int.Parse(Console.ReadLine());
            Console.Write("Enter Ending Number : ");
            int endNum = int.Parse(Console.ReadLine());
            Perform.PrintPrimeNum(startNum, endNum);
        }
    }
}
