using System;
using FactoryDesignPattern.Product;

namespace FactoryDesignPattern.ConcreteProduct
{
    public class Trunk:IVehical
    {
        public int getSerialNumber()
        {
           Console.WriteLine("Trunk number is 10 ");
           return 10;
        }

        public void loading()
        {
            Console.WriteLine(" loading in Trunk ");

        }

        public string getName()
        {
            return "Trunk";
        }
    }
}
