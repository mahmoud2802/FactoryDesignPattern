using FactoryDesignPattern.ConcreteProduct;
using FactoryDesignPattern.Creator;
using FactoryDesignPattern.Product;

namespace FactoryDesignPattern.ConcreteCreator
{
    public class RoadLogestic : Transport
    {
        protected override IVehical createVehical()
        {
            return new Trunk();
        }
    }
}
