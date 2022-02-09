using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface
{
     class Driver1
    {
        public void Drive(Car objCar)
        {
            Console.WriteLine("Driver is driving a car");
            objCar.DriveCar();
            Console.WriteLine();
        }
        public void Drive(Scooter objScooter)
        {
            Console.WriteLine("Driver is driving a car");
            objScooter.DriveScooter();
            Console.WriteLine();
        }

    }
}
