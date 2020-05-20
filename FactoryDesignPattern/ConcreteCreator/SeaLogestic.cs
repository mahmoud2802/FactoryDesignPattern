﻿using FactoryDesignPattern.ConcreteProduct;
using FactoryDesignPattern.Creator;
using FactoryDesignPattern.Product;

namespace FactoryDesignPattern.ConcreteCreator
{
    public class SeaLogestic : Transport
    {
        protected override IVehical createVehical()
        {
            return new Ship();
        }
    }
}
