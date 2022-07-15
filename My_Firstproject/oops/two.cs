using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.oops
{
    class two
    {
        public int model;
        public string name;
        public int price;
    
        static void Main(string[]args)
        {
            Car  car1= new Car();

            car1.model = 111;
            car1.name  = "BMW";
            car1.price = 1000000;


            Car car2= new Car();


            car2.model = 112;
            car2.name = "ENOVA";
            car2.price = 700000;


            Console.WriteLine(car1.model + " " + car1.name + " " + car1.price);
            Console.WriteLine(car2.model + " " + car2.name + " " + car2.price);

           

        }
    }
}
