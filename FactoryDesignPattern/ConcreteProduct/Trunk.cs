using System;
using FactoryDesignPattern.Product;

namespace FactoryDesignPattern.ConcreteProduct
{
    public class Trunk:Vehical
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
    }
}
