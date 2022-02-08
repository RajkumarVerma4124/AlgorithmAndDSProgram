using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace AlgorithmAndDSProgram
{
    public class RegexPattern
    {
        //Declaring regex pattern and varibales
        public readonly Regex firstName = new Regex(@"(^[A-Z]{1}[a-z]{2,}$)");
        public readonly Regex lastName = new Regex(@"(^[A-Z]{1}[a-z]{2,}$)");
        public readonly Regex phoneNum = new Regex(@"(^91[ ][0-9]{10}$)");
        public readonly Regex dateTime = new Regex(@"(^(((0[1-9]|[12][0-9]|30)[-/]?(0[13-9]|1[012])|31[-/]?(0[13578]|1[02])|(0[1-9]|1[0-9]|2[0-8])[-/]?02)[-/]?[0-9]{4}|29[-/]?02[-/]?([0-9]{2}(([2468][048]|[02468][48])|[13579][26])|([13579][26]|[02468][048]|0[0-9]|1[0-6])00))$)");
        public string fName, lName, phnNum, dtTime;

        //Constructor to initialize values
        public RegexPattern()
        {
            this.fName = null;
            this.lName = null;
            this.phnNum = null;
            this.dtTime = null;
        }

        //Method to check and take the first name format
        public bool FirstName()
        {
            Console.Write("Enter the FirstName : ");
            fName = Console.ReadLine();
            if (firstName.IsMatch(fName))
                return true;
            else
            {
                Console.WriteLine("The given name is not valid");
                FirstName();
            }
            return default;
        }

        //Method to check and take the last name format
        public bool LastName()
        {
            Console.Write("Enter the last name : ");
            lName = Console.ReadLine();
            if (lastName.IsMatch(lName))
                return true;
            else
            {
                Console.WriteLine("The given last name is not valid");
                LastName();
            }
            return default;
        }

        //Method to check and take the phone number format
        public bool PhoneNumber()
        {
            Console.Write("Enter the phone number in 91 123456787 format : ");
            phnNum = Console.ReadLine();
            if (phoneNum.IsMatch(phnNum))
                return true;
            else
            {
                Console.WriteLine("The given phone number is not valid");
                PhoneNumber();
            }
            return default;
        }

        //Method to check and take the date time format
        public bool DateTime()
        {
            Console.Write("Enter the date and time in dd/mm/yyyy format : ");
            dtTime = Console.ReadLine();
            if (dateTime.IsMatch(dtTime))
                return true;
            else
            {
                Console.WriteLine("The given date time format is not valid");
                DateTime();
            }
            return default;
        }

        //Method to print the customize message
        public void Message()
        {
            string fullName = fName+" "+lName;
            Console.WriteLine($"Hello {fName}, We have your full name as {fullName} in our system.\nYour contact number is {phnNum}. Please, let us know in case of any clarification.\nThank you BridgeLabz {dtTime}.");
        }
    }
}
