using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task10
{
    internal class Car
    {
        public string Brand { get; private set; }

        public Car(string brand)
        {
            Brand = brand;
        }

        public string ToString()
        {
            return Brand;
        }
    }
}
