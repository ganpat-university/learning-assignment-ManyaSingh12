using System;

namespace Demo_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo of overload methods"); 
            Demo01();

        }
        static void Demo01()
        {
            Car objCar = new Car();
            Driver1 objDriver = new Driver1();
            Scooter objScooter = new Scooter();
            objDriver.Drive(objCar);
            objDriver.Drive(objScooter);

        }
    }
}
