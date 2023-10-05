using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLas1
{
    class Car
    {
        public int numberOfWheels;
        public int valueOfCar;
        public string modelOfCar;
        public string colorOfCar;

        public Car(int _numberOfWheels,int _valueOfVCar,string _modelOfcar,string _colorOfCar)
        {
            numberOfWheels = _numberOfWheels;
            valueOfCar = _valueOfVCar;
            modelOfCar = _modelOfcar;
            colorOfCar = _colorOfCar;

        }

        public void runCar()
        {
            Console.WriteLine("Car is running....");
        }
        public void stopCar()
        {
            Console.WriteLine("Car stopped!");
        }
    }
}
