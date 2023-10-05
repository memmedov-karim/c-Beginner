using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Static
    {

        public  void nameParser(string name)
        {
            Console.WriteLine("Hello "+name+ " How is Going?");
        }
        public static void ageParser(int age)
        {
            Console.WriteLine("You are " + age + " years old!");
        }
    }
}
