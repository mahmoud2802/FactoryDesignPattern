﻿using System;
using FactoryDesignPattern.Product;

namespace FactoryDesignPattern.ConcreteProduct
{
    public class Ship:IVehical
    {
        public int getSerialNumber()
        {
            Console.WriteLine("Ship number is 50 ");
            return 50;
        }

        public void loading()
        {
            Console.WriteLine("loading in ship ");

        }

        public string getName()
        {
            return "Ship";
        }
    }
}
