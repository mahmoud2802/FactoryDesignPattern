using System;
using FactoryDesignPattern.Product;

namespace FactoryDesignPattern.Creator
{
    public abstract class Transport
    {
        public void Deliver()
        {
            ////ما در اینجا وظیفه ساخته محصول را به کلاس دیگری واگذار می کنیم.
            IVehical vehical = createVehical();
            vehical.getSerialNumber();
            vehical.loading();
            Console.WriteLine($"it is Deliver By {vehical.getName()}");

            ////
            ///بقیه گزینه ها
            ///
        }

        protected abstract IVehical createVehical();


    }
}
