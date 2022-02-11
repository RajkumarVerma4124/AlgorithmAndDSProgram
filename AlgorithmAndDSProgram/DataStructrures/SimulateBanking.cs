using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSProgram.DataStructrures
{
    /// <summary>
    /// Simulate Banking Cash Counter
    /// </summary>
    public class SimulateBanking
    {
        //Initializing the varibales and Queue object;
        public static int bankBal = 100000;
        public static int peopleCount, depositAmount, withdrawAmout;
        public static Queue<int> counter = new Queue<int>();

        //Method to add or withraw money to the bank account
        public static void CashCounter()
        {
            Console.WriteLine("Banking Cash Counter Program\n");
            //Banking cash counter program using switch case 
            while (true)
            {
                Console.WriteLine("Welcome To The NewCorp Bank");
                Console.WriteLine("1: Add People To Queue \n2: Deposit Money To The Bank \n3: Withdraw Money To The Bank \n4: Check Bank Balance \n5: Check Queue \n6: Go Back");
                Console.Write("Enter a choice from above : ");
                bool flag = int.TryParse(Console.ReadLine(), out int choice);
                if(flag)
                {
                    switch (choice)
                    {
                        case 1:
                            //Adding people to the queue
                            Console.Write("Enter the number of people are in the line : ");
                            peopleCount = int.Parse(Console.ReadLine());
                            for (int i = 1; i <= peopleCount; i++)
                                counter.Enqueue(i);
                            break;
                        case 2:
                            //Removing people from queue who wants to deposit in bank
                            if(!counter.IsEmpty())
                            {
                                Console.Write("Enter the amount you want to deposit : ");
                                depositAmount = int.Parse(Console.ReadLine());
                                bankBal += depositAmount;
                                Console.WriteLine("You deposited the amount {0} sucessfully", depositAmount);
                                counter.Dequeue();
                            }
                            else
                            {
                                Console.WriteLine("There are no people in the queue\n");
                                continue;
                            }
                            break;
                        case 3:
                            //Removing people from queue who wants to withraw money from bank
                            if (!counter.IsEmpty())
                            {
                                Console.WriteLine("Enter the amount you want to withdraw : ");
                                withdrawAmout = int.Parse(Console.ReadLine());
                                if (bankBal <= withdrawAmout)
                                    bankBal += withdrawAmout;
                                bankBal -= withdrawAmout;
                                Console.WriteLine("You withraw the amount {0} sucessfully", withdrawAmout);
                                counter.Dequeue();
                            }
                            else
                            {
                                Console.WriteLine("There are no people in the queue\n");
                                continue;
                            }
                            break;
                        case 4:
                            //Showing the bank balance  
                            Console.WriteLine("Current Bank Balance is {0}", bankBal);
                            break;
                        case 5:
                            //Checking the queue is empty or not
                            if (counter.IsEmpty())
                                Console.WriteLine("The Queue has been cleared\n");
                            else
                                Console.WriteLine("The Queue hasnt been cleared yet\n");
                            continue;
                        case 6:
                            DSProgram.DataStructure();
                            break;
                        default:
                            Console.WriteLine("Wrong Choice");
                            continue;
                    }
                }
                else
                    Console.WriteLine("Please Input Some Choice");
            }
        }
    }
}
