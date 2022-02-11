using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSProgram
{
    public class CustomizeMessageProgram
    {
        /// <summary>
        /// Customizing the message
        /// </summary>
        public static void PrintMessage()
        {
            //Checking the given user details are valid
            RegexPattern regexPattern = new RegexPattern();
            if(regexPattern.FirstName() == true)
                Console.WriteLine("The first name is valid");
            if (regexPattern.LastName() == true)
                Console.WriteLine("The last name is valid"); 
            if (regexPattern.PhoneNumber() == true)
                Console.WriteLine("The phone number is valid");
            if (regexPattern.CurrentDate() == true)
                Console.WriteLine("The date time is valid");
            regexPattern.Message();
        }
    }
}
