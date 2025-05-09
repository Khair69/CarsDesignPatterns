using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsDesignPattern.Rev
{
    internal class V8 : IRevBehavior
    {
        public void Rev()
        {
            Console.WriteLine("Vroom Vrooom i am a V8 engine. Probably in an american muscle car or smth Vroom Vroooom.");
        }
    }
}
