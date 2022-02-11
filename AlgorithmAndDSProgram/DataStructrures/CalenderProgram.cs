using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSProgram.DataStructrures
{
    public class CalenderProgram
    {
        public static void Calender()
        {
            //Initializing the variables
            Console.WriteLine("Printing The Given Calender Using Month And Year Program\n");
            bool flag = false;
            int month=0, year=0;

            //Entering the value of month
            while (!flag)
            {
                Console.Write("Enter a month : ");
                month = int.Parse(Console.ReadLine());
                if (month > 12 || month < 1)
                    Console.WriteLine("Enter a valid month");   
                else
                    flag = true;
            }

            flag = false;

            //Entering the value of year 
            while(!flag)
            {
                Console.Write("Enter a year : ");
                year = int.Parse(Console.ReadLine());
                if (year.ToString().Length != 4 )
                    Console.WriteLine("Enter a valid year");                
                else
                    flag = true;
            }
           
            //Calling the calender functiont print calender using 2d array
            Perform.Calendar(month, year);
        }
    }
}
