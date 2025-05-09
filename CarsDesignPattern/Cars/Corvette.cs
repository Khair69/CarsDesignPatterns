using CarsDesignPattern.Rev;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsDesignPattern.Cars
{
    internal class Corvette : Car
    {
        public Corvette()
        {
            revBehavior = new V8();
        }

        public override void Display()
        {
            Console.WriteLine("a 2025 Chevrolet Corvette for $68,000 is the best V8 you can buy in 2025.");
        }
    }
}
