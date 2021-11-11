using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    public class TriCycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Were building a TriCycle!");
        }
    }
}
