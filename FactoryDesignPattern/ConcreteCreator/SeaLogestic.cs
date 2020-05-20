using DesignPattern.Creator;
using FactoryDesignPattern.ConcreteProduct;
using FactoryDesignPattern.Product;

namespace DesignPattern.ConcreteCreator
{
    public class SeaLogestic : Logestic
    {
        protected override Vehical createVehical()
        {
            return new Ship();
        }
    }
}
