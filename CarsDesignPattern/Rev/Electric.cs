using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsDesignPattern.Rev
{
    internal class Electric : IRevBehavior
    {
        public void Rev()
        {
            Console.WriteLine("*Robot Noises*");
        }
    }
}
