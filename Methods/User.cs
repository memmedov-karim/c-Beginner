using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class User
    {
        private int weight;
        public int Weight { 
            get
            {
                return weight;

            }
            set
            {
                Console.WriteLine("Value from Program.cs:"+value);
                weight = value;
            }
        }
    }
}
