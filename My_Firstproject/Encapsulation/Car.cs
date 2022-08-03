using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Encapsulation
{
    class Car
    { 
        int model_number;
        string  car_name;
        int car_price;
        int car_speed;
        public int Model_number
        {
            get
            {
                return model_number;
            }
            set
            {
                model_number = value;
            }
        }
        public string Car_Name
        {
            get
            {
                return car_name;

            }
            set
            {
                car_name = value;
            }
        }
        public int Car_Price
        {
            get
            {
                return car_price;

            }
            set
            {
                car_price = value;
            }
        }
            public int Car_speed
            {
              get
              {
                return car_speed;
              }
              set
              {
                car_speed = value; 
              }
            }
     }
      class Carinfo
      {
        static void Main(string[]args)
        {
            Car c = new Car();
            c.Model_number = 2345;
            c.Car_Name = "VENU";
            c.Car_Price = 1100000;
            c.Car_speed = 80;

            Console.WriteLine(c.Model_number + " " + c.Car_Name + " " + c.Car_Price + " " + c.Car_speed);
        }
      }
            

            
 }

    

