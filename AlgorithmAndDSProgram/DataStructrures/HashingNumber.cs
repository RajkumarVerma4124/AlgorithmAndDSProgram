using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgorithmAndDSProgram.DataStructrures
{
    public class HashingNumber
    {
        //Method to create a slot of 10 to store chain of number using hashtable
        public static void NumberSlot(HashSlots<int> hashedSlots)
        {
            Console.WriteLine("Slots to store chain of numbers program\n");
            //Reading the file data and adding into the hashslots
            string filePath = @"E:\CODING\Coding\React Web Apps\coreAPI\Fellowship\AlgorithmAndDSProgram\AlgorithmAndDSProgram\DataStructrures\NumberSlots.txt";
            string fileData = File.ReadAllText(filePath);
            string[] fileNum = fileData.Split(' ');
            for (int i = 0; i < fileNum.Length - 1; i++)
            {
                hashedSlots.AddData(int.Parse((fileNum[i])));
            }
            hashedSlots.Display();

            Console.WriteLine("Enter a number to search:");
            int searhNum = int.Parse(Console.ReadLine());

            //Search element in Hash Table
            if (hashedSlots.Search(searhNum))
            {
                //If found removinf that number and saving modded file
                Console.WriteLine("Value {0} is Present in Hash Table", searhNum);
                hashedSlots.Remove(searhNum);
                File.WriteAllText(filePath, hashedSlots.Display());
            }
            else
            {   //If not founf adding and writing that number to the file
                hashedSlots.AddData(searhNum);
                Console.WriteLine("Value {0} is not Present in Hash Table", searhNum);
                File.WriteAllText(filePath, hashedSlots.Display());
            }
        }
    }
}
