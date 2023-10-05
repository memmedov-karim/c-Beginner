using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM2
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance = 1200;
            Console.WriteLine("Welcome to our bank!");
            Console.WriteLine("1-Get your balance!");
            Console.WriteLine("2-Add your balance!");
            Console.WriteLine("3-Get money from your balance!");
            Console.WriteLine("q-Exit");
            Console.Write("What is your choise: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Your current balance:" + balance);
                    break;
                case "2":
                    Console.Write("Enter money what do you want to add: ");
                    int money = Convert.ToInt32(Console.ReadLine());
                    balance += money;
                    Console.WriteLine("Your balance:" + balance);
                    break;
                case "3":
                    Console.Write("Enter money what do you want to get: ");
                    int money1 = Convert.ToInt32(Console.ReadLine());
                    if (money1 > balance)
                    {
                        Console.WriteLine("You can not get " + money1 + " from your balance");
                    }
                    else
                    {
                        balance -= money1;
                        Console.WriteLine("Your balance:", +balance);
                    }
                    break;
                case "q":
                    Console.WriteLine("You exit succesfuly!");
                    break;
                default:
                    Console.WriteLine("Please selecet correct option!");
                    break;
            
            }

        }
    }
}
