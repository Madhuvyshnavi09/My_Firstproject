using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Dotnet
{
    class Cars
    {
        public int model_number;
        public string car_name;
        public int car_price;
        public string car_color;

        static void Main(string[]args)
        {
            Cars audi = new Cars();
            audi.model_number = 234;
            audi.car_price = 500000;
            audi.car_name = "BMW";
            audi.car_color = "white";
            Console.WriteLine(audi.model_number+" "+audi.car_price+  " "+audi.car_color);





            Cars BMW= new Cars();
            audi.model_number = 234;
            audi.car_price = 500000;
            audi.car_name = "Bmw";
            audi.car_color = "white";
            Console.WriteLine(audi.model_number + " " + audi.car_price + " " + audi.car_color);





            Cars VENU = new Cars();
            audi.model_number = 234;
            audi.car_price = 500000;
            audi.car_name = "venu";
            audi.car_color = "white";
            Console.WriteLine(audi.model_number + " " + audi.car_price + " " + audi.car_color);


        }
    }
}
