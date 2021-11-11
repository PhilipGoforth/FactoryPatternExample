using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    public class MotorCycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Were building a MotorCycle!");
        }
    }
}
