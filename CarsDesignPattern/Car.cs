using CarsDesignPattern.Rev;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsDesignPattern
{
    internal abstract class Car
    {
        protected IRevBehavior revBehavior;

        public abstract void Display();

        public void Honk()
        {
            Console.WriteLine("Beep Beep");
        }

        public void PreformRev()
        {
            revBehavior.Rev();
        }
    }
}
