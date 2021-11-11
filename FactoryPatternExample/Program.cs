using System;

namespace FactoryPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires do you have?");
            int tires = Convert.ToInt32(Console.ReadLine());

            IVehicle vehicle = VehicleFactory.GetVehicle(tires);
            vehicle.Drive();
            Console.ReadLine();
        }
    }
}
