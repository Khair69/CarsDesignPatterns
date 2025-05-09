using CarsDesignPattern.Cars;

namespace CarsDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car corvette = new Corvette();
            corvette.PreformRev();
            corvette.Display();
            corvette.Honk();
        }
    }
}
