using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Inheritence
{
    class Engine
    {
        string type;
        public string Type
        {
            get { return type; }
            set { type = value; }


        }
        class Car
        {
            int model_no;
            string Cname;
            int price;
            Engine en;
        }
        public int model_no
        {
            get { return model_no; }
            set { model_no = value; }

        }
        public string CName
        {
            get;
            set;
        }
        public int price
        {
            get { return price; }
            set { price = value; }
        }

        public Engine en
        {
            get { return en; }
            set { en = value; }
        }
    }
}

        /* static void Main(string[] args)
        
           Car c = new Car();
           c.Cname = "BMW";
           c. model_no = 567;
           c.price = 898989;
           c.en = new Engine();*\
            


            