using System;
using DesignPattern.ConcreteCreator;
using FactoryDesignPattern.ConcreteCreator;
using FactoryDesignPattern.Creator;

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

            Transport _deliver1 = new AirLogestic();
            _deliver1.Deliver();
            Console.WriteLine("/////////////////////////////////////");
            Transport _deliver2 = new RoadLogestic();
            _deliver2.Deliver();
            Console.WriteLine("/////////////////////////////////////");

            Transport _deliver3 = new SeaLogestic();
            _deliver3.Deliver();
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
