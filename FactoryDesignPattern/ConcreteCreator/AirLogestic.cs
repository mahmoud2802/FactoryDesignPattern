using FactoryDesignPattern.ConcreteProduct;
using FactoryDesignPattern.Creator;
using FactoryDesignPattern.Product;

namespace DesignPattern.ConcreteCreator
{
    public class AirLogestic : Transport
    {

        protected override IVehical createVehical()
        {
            return new AirPlane();
        }
    }
}
