using System;
using FactoryDesignPattern.Product;

namespace FactoryDesignPattern.ConcreteProduct
{
    public class AirPlane:IVehical
    {
        public int getSerialNumber()
        {
            Console.WriteLine("Air plane Number is 600 ");
            return 600;
        }

        public void loading()
        {
            Console.WriteLine(" Loading in Airplane ");

        }

        public string getName()
        {
            return "AirPlane";
        }
    }
}
