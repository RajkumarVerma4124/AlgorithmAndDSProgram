using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSProgram
{
    public class CustomizeMessageProgram
    {
        public static void PrintMessage()
        {
            RegexPattern regexPattern = new RegexPattern();
            /*if(regexPattern.FirstName() == true)
                Console.WriteLine("The first name is valid");
            if (regexPattern.LastName() == true)
                Console.WriteLine("The last name is valid"); 
            if (regexPattern.PhoneNumber() == true)
                Console.WriteLine("The phone number is valid");*/
            if (regexPattern.DateTime() == true)
                Console.WriteLine("The date time is valid");
            regexPattern.Message();
        }
    }
}
