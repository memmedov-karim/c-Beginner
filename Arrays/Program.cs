using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[6];

            for(int i = 0; i < nums.Length; i++)
            {
                Console.Write("Please include value of " + (i+1)+ "-nth: ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int j= 0; j < nums.Length; j++)
            {
                Console.WriteLine(nums[j]);
            }
            
            
        }
    }
}
