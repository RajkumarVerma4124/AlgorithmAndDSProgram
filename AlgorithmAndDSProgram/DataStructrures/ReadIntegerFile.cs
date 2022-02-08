using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgorithmAndDSProgram.DataStructrures
{
    public class ReadIntegerFile
    {
        public static void ReadIntFile()
        {
            Console.WriteLine("Read File Program And Store In Ordered List \n");
            OrderedList<int> list = new OrderedList<int>();

            while (true)
            {
                //Storing the path location in string variable initializing variable, string array and list
                string fileStr;
                string filePath = @"E:\CODING\Coding\React Web Apps\coreAPI\Fellowship\AlgorithmAndDSProgram\AlgorithmAndDSProgram\DataStructrures\InputFile.txt";
                string[] fileData;

                Console.WriteLine("1: Writing Data Into The File \n2: Empty The file \n3: Read And Store Integer From The File And Add Into Ordered List \n4: Search To Add Or Delete Data Value \n5: Display \n6: Go Back");
                Console.Write("Enter a choice from above : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //Storing the path location in string variable
                        Console.Write("Enter a number in this format 10 20 30  : ");
                        fileStr = Console.ReadLine();

                        //Writing the string to the file
                        File.WriteAllText(filePath, fileStr);
                        break;
                    case 2:
                        //Emtying the file
                        fileStr = string.Empty;
                        File.WriteAllText(filePath, fileStr);
                        break;
                    case 3:
                        //Storing the words from file into the string array and pushed into ordered list
                        Console.WriteLine("Reading data from the file.......");
                        fileData = File.ReadAllText(filePath).Split(' ');
                        if (fileData.Length.Equals(1))
                            Console.WriteLine("File Is Empty");
                        else
                        {
                            Console.WriteLine("File Read Successfully");

                            //Pushing the data into the ordered list
                            for (int i = 0; i < fileData.Length; i++)
                            {
                                list.Add(Convert.ToInt32(fileData[i]));
                            }
                        }
                        break;
                    case 4:
                        //Search to add or delete value
                        Console.Write("Enter a number to search : ");
                        int num = int.Parse(Console.ReadLine());
                        if (list.Search(num) < 0)
                            list.Add(num);
                        else
                            Console.WriteLine("The searched Word {0} is deleted", list.Delete(num));
                        File.WriteAllText(filePath, list.ToString());
                        break;
                    case 5:
                        //Displaying the list values
                        list.Display();
                        break;
                    case 6:
                        DSProgram.DataStructure();
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
            }
        }
    }
}
