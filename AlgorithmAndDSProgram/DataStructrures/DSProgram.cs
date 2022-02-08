using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmAndDSProgram;

namespace AlgorithmAndDSProgram.DataStructrures
{
    public class DSProgram
    {
        public static void DataStructure()
        {
            //Calling the method to read and write file data into unorder or order list
            while(true)
            {
                Console.WriteLine("\n1: Read String File And Add Into Unorderd List \n2: Read String Of Numbres File And Add Into Ordered List In Integer Format\n3: Go Back");
                Console.Write("Enter a choice from above : ");
                switch(int.Parse(Console.ReadLine()))
                {
                    case 1:
                        //Method to read strings and add into unordered list
                        ReadTextFile.ReadStringFile();
                        break;
                    case 2:
                        //Method to read integers and add into ordered list
                        ReadIntegerFile.ReadIntFile();
                        break;
                    case 3:
                        Program.Main(null);
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        continue;
                }
            }
        }
    }
}
