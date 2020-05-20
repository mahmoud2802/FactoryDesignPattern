namespace FactoryDesignPattern.Product
{
    /// <summary>
    /// محصول ما
    /// </summary>
    public interface Vehical
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

        ///////میتوانید گزینه ها دیگر را نیز اضافه کنید
    }
}
