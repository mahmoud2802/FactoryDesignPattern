namespace FactoryDesignPattern.Product
{
    /// <summary>
    /// محصول ما
    /// </summary>
    public interface IVehical
    {

        /// <summary>
        /// گرفتن شماره وسلیه
        /// </summary>
        /// <returns></returns>
        int getSerialNumber();
        /// <summary>
        /// بارگیری وسیله نقلیه
        /// </summary>
        void loading();

        string getName();

        ///////میتوانید گزینه ها دیگر را نیز اضافه کنید
    }
}
