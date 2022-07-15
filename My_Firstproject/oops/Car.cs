using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.oops
{
    class Car
    {
        public int model;
        public string name;
        public int price;






        static void Main(string[]args)
        {


            Car car1 = new Car();


            car1.model = 111;
            car1.name = "ENOVA";
            car1.price = 100000;

            Console.WriteLine(car1.model + "" + car1.name + " " + car1.price);




          
                    
            


        }
    }
}
