using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int tires)
        {
            switch (tires)
            {
                case 1:
                    return new Unicycle();
                case 2:
                    return new MotorCycle();
                case 3:
                    return new TriCycle();
                case 4:
                    return new Car();
                case 18:
                    return new SemiTruck();
                default:
                    return new Car();
            }
        }
    }
}
