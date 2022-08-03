using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Encapsulation
{
    class Cars
    {
        int id;
        private int Modelnumber;
        private string name;
        private string colour;
        private int price;
        private int speed;


        public int  modelnumber
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name;}
            set { name = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public int Price
        {
            get { return price;}
            set { price = value; }
        }
        public int Speed
        {
            get { return speed;}
            set { speed = value; }
        }
        class carinfo
        {
            static void Main(string[] args)
            {
                Cars e = new Cars();
                e.Modelnumber = 244;
                e.Name = "volvo";
                e.price = 250000;
                e.speed = 70;
        }   }

   
    }
}
