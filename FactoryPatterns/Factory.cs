using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns
{
    public static class Factory
    {
        public static IVehical GetVehical(string tires)
        {
            if (tires == "2")
            {
                var x = new Motorcycle();
                return x;
            }
            else
            {
                var y = new Truck();
                return y;
            }
        }
    }
}
