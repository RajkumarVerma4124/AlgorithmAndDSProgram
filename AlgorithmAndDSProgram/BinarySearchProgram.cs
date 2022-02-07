using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgorithmAndDSProgram
{
    public class BinarySearchProgram
    {
        public static void BinarySearchWord()
        {
            Console.WriteLine("Binary Search Program To Search Words From File\n");
            string[] words = null;
            Console.WriteLine("Reading words from the file");
            string filePath = @"E:\CODING\Coding\React Web Apps\coreAPI\Fellowship\AlgorithmAndDSProgram\AlgorithmAndDSProgram\RandomText.txt";
            if (File.Exists(filePath))
            {
                words = File.ReadAllText(filePath).Split(',');
            }
            Console.WriteLine();

            //Sorting the words list
            Array.Sort(words);

            Console.Write("After sorting the list : ");
            foreach (string word in words)
            {
                Console.Write(word.Trim() + " ");
            }
            Console.WriteLine();

            Console.Write("Enter a word to search : ");
            string search = Console.ReadLine();
            bool result = Perform.BinarySearch(words, search);
            if (result)
                Console.WriteLine("The word {0} is present in the list", search);
            else
                Console.WriteLine("The word {0} is not present in the list", search);
            Console.ReadLine();
        }
    }
}
