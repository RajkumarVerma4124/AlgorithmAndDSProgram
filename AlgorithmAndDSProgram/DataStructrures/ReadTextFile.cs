using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgorithmAndDSProgram.DataStructrures
{
    public class ReadTextFile
    {
        public static void ReadFile()
        {
            Console.WriteLine("UnOrdered Read File Program\n");
            UnorderedList<string> list = new UnorderedList<string>();

            while (true)
            {
                //Storing the path location in string variable initializing variable, string array and list
                string fileStr;
                string filePath = @"E:\CODING\Coding\React Web Apps\coreAPI\Fellowship\AlgorithmAndDSProgram\AlgorithmAndDSProgram\DataStructrures\InputFile.txt";
                string[] fileData;

                Console.WriteLine("1: Writing Data Into The File \n2: Empty The file \n3: Read And Store Text From The File And Add Into LinkList \n4: Search And Add Or Delete Value \n5: Display \n6: Exit");
                Console.Write("Enter a choice from above : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //Storing the path location in string variable
                        Console.Write("Enter a sentence of random words : ");
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
                        //Storing the words from file into the string array and pushed into linlist
                        Console.WriteLine("Reading data from the file.......");
                        fileData = File.ReadAllText(filePath).Split(' ');
                        if (fileData.Length.Equals(1))
                            Console.WriteLine("File Is Empty");
                        else
                        {
                            Console.WriteLine("File Read Successfully");

                            //Pushing the data into the unordered list
                            for (int i = 0; i < fileData.Length; i++)
                            {
                                list.AddLast(fileData[i]);
                            }
                        } 
                        break;
                    case 4:
                        //Search and add or delete value
                        Console.Write("Enter a word to search : ");
                        string word = Console.ReadLine();
                        if (list.Search(word) < 0)
                            list.AddLast(word);
                        else
                            Console.WriteLine("The searched Word {0} is deleteds",list.Delete(word));
                        File.WriteAllText(filePath, list.ToString());
                        break;
                    case 5:
                        //Displaying the list values
                        list.Display();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
            }
        }
    }
}
