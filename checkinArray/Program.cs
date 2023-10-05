using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2,1,1,1,1,1,1, 3, 4, 5, 6, 7, 8, 9, 1, 4, 2, 5, 6, 2, 7, 11, 13, 1, 43, 43, 56, 4, 343, 43 };
            Console.Write("Please enter number what do you want to check: ");
            int checkingNumber = Convert.ToInt32(Console.ReadLine());

            int numOfNum = 0;

            foreach(int num in numbers)
            {
                if(num == checkingNumber)
                {
                    numOfNum += 1;
                }
            }
            string res = numOfNum == 0 ? "There is not number which you include" : "There are " + numOfNum + " numbers in this array";
            Console.WriteLine(res);
        }
    }
}
