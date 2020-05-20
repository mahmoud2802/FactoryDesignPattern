using System;
using DesignPattern.ConcreteCreator;
using DesignPattern.Creator;

namespace DesignPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //************************************************************
            //ما به راحتی بدون اینکه نیاز باشد کد های قبلی تغییر دهیم می توانیم وسیله(محصول) جدید اضافه کنیم
            //این مثال مربوط به پست دیزانپتر ها در ایستاگرام @mahmoud2802 می باشد
            //************************************************************

            Logestic _logestic1 = new AirLogestic();
            _logestic1.orderVehical();
            Console.WriteLine("/////////////////////////////////////");
            Logestic _logestic2 = new GroundLogestic();
            _logestic2.orderVehical();
            Console.WriteLine("/////////////////////////////////////");

            Logestic _logestic3 = new SeaLogestic();
            _logestic3.orderVehical();
            Console.WriteLine("/////////////////////////////////////");
            printInstagram();
        }

        static void printInstagram()
        {
            Console.WriteLine("************************");
            Console.WriteLine("Please follow me on Instagram @mahmoud2802");
            Console.WriteLine("************************");
        }
    }
}
