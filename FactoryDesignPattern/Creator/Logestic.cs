using FactoryDesignPattern.Product;

namespace DesignPattern.Creator
{
    public abstract class Logestic
    {
        public void orderVehical()
        {
            ////ما در اینجا وظیفه ساخته محصول را به کلاس دیگری واگذار می کنیم.
            Vehical vehical = createVehical();
            vehical.getSerialNumber();
            vehical.loading();
            ////
            ///بقیه گزینه ها
            ///
        }

        protected abstract Vehical createVehical();


    }
}
