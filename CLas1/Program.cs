using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLas1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car(4, 300000, "Mercedes", "Black");
            Console.WriteLine(mycar.numberOfWheels + "\n" + mycar.valueOfCar +"\n"+mycar.modelOfCar+"\n"+mycar.colorOfCar);
        }
    }
}
