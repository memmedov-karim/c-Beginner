using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Our bank!\n");
            Console.WriteLine("Enter 1 see your balance:\nEnter 2 add money to balance:\nEnter 3 get money from balance:\nEnter q to exit:");
            while (true)
            {
                string option = Console.ReadLine();
                int balance = 100;
                if (option == "1")
                {
                    Console.WriteLine("Your balance:" + balance);
                }
                else if (option == "2")
                {
                    Console.Write("Enter money to add your balance:");
                    int money = Convert.ToInt32(Console.ReadLine());
                    balance += money;
                    Console.WriteLine("Your balance:" + balance);
                }
                else if (option == "3")
                {
                    Console.WriteLine("How many money you get:");
                    int money = Convert.ToInt32(Console.ReadLine());

                    balance -= money;
                    Console.WriteLine("Your balance:" + balance);

                }
                else if (option == "q")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please include correct option!");
                }

            }
            
            

        }
    }
}
