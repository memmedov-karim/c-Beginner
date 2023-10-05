using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i = 0; i <= num; i++)
            {
                sum += i;
            }
            double div = sum / num;
            string res = div >= 50 ? "Succes:" + div : "Unsucces:" + div;
            Console.WriteLine(res);
        }
    }
}
