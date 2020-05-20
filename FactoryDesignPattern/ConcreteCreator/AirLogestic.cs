using DesignPattern.Creator;
using FactoryDesignPattern.ConcreteProduct;
using FactoryDesignPattern.Product;

namespace DesignPattern.ConcreteCreator
{
    public class AirLogestic : Logestic
    {

        protected override Vehical createVehical()
        {
            return new AirPlane();
        }
    }
}
