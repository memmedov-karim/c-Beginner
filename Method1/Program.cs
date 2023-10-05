using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method1
{
    class Program
    {
        static void Main(string[] args)
        {
            operationBetweenTwoNums(23, "+", 37);
            operationBetweenTwoNums(23, "-", 37);
            operationBetweenTwoNums(23, "x", 37);
            operationBetweenTwoNums(23, ":", 37);
            string nm = getName("Rasim", "Mammadov");
            Console.WriteLine(nm);
        }
        static string getName(string name,string surname)
        {
            string fullname = name + " " + surname;
            return fullname;
        }
        static void operationBetweenTwoNums(int num1,string operation,int num2)
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case "x":
                    Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
                    break;
                case ":":
                    if(num1%num2 == 0)
                    {
                        Console.WriteLine($"{num1} : {num2} = {num1 / num2}");
                    }
                    else
                    { 
                        Console.WriteLine($"{num1} : {num2} = {(double)num1/num2}");
                    }
                    
                    break;
                default:
                    Console.WriteLine("Please include correct operations!");
                    break;

            }

        }
    }
}
