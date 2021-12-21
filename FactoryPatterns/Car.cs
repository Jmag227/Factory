using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns
{
    internal class Motorcycle : IVehical
    {
        public void Drive()
        {
            Console.WriteLine("Driving.... very fast");
        }
    }
}
