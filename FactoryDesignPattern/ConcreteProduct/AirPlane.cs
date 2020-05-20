﻿using System;
using FactoryDesignPattern.Product;

namespace FactoryDesignPattern.ConcreteProduct
{
    public class AirPlane:Vehical
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
    }
}
