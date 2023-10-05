using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static string Say(string arg)
        {
            return arg;
        }
        static void Main(string[] args)
        {
            int a = 5;
            byte b = (byte)a;
            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());
            string m = "3";
            string n = "6";
            int x = Convert.ToInt32(m);
            int y = Convert.ToInt32(n);
            int z = int.Parse(m);
            Console.WriteLine(x == z);
            Console.WriteLine(x+y);

            //Console.WriteLine(Say("salam"));
            //int num1 = 20;
            //int num2 = 10;
            //Console.WriteLine(num1+":"+ num2);
            //int c = num1;
            //num1 = num2;
            //num2 = c;
            //Console.WriteLine(num1 + ":" + num2);


            //byte minVal = byte.MinValue;
            //byte MaxVal = byte.MaxValue;
            //byte tes = 100;
            //float pi = 3.14F;
            //Console.WriteLine(float.MaxValue);
            //Console.WriteLine(pi*10);
            //Console.WriteLine(tes * 3);
            //Console.WriteLine("Min value:"+minVal);
            //Console.WriteLine("Max value of Long:"+long.MaxValue);
            //double div = num2 / num1;
            //Console.WriteLine(div);
            //Console.Write("Please enter your name and surname :");
            //string Name = Console.ReadLine();
            //Console.Write("Please enter your Age :");
            //int Age = Convert.ToInt32(Console.ReadLine());
            //string own = Age >= 18 ? "You can enter this party because you are over 18" :"You can not enter this party";


            //Console.WriteLine("Info About You");
            //string sayd = Say();
            //Console.WriteLine(sayd);
            //Console.WriteLine("Name:" + Name + "\n" + "Age:" + Age+"\n" + "canEnter? :"+own);

        }
    }
}
