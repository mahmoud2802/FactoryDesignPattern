using DesignPattern.Creator;
using FactoryDesignPattern.ConcreteProduct;
using FactoryDesignPattern.Product;

namespace DesignPattern.ConcreteCreator
{
    public class GroundLogestic : Logestic
    {
        protected override Vehical createVehical()
        {
            return new Trunk();
        }
    }
}
