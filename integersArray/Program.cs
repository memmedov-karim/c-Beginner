using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integersArray
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter Length of Array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter " + (i + 1) + "element-");
                nums[i] = Convert.ToInt32(Console.ReadLine());

            }
            int numofOdd = 0;
            int numofEven = 0;
            int sumofOdd = 0;
            int sumofEven = 0;
            foreach(int num in nums)
            {
                if (num % 2 == 0)
                {
                    sumofEven += num;
                    numofEven++;
                }
                else
                {
                    sumofOdd += num;
                    numofOdd++;
                }
            }
            Console.WriteLine("Number of Odd numbers:" + numofOdd);
            Console.WriteLine("Number of Even numbers: " + numofEven);
            Console.WriteLine("Sum of Odd numbers: " + sumofOdd);
            Console.WriteLine("Sum of Even numbers: " + sumofEven);
            string res = sumofEven > sumofOdd ? "Sum of Even numbers bigger than sum of Odd numbers" : sumofEven < sumofOdd ? "Sum of Even numbers less than sum of Odd numbers" : "Sum of Even numbers and Odd are equals";
            Console.WriteLine(res);
        }
    }
}
