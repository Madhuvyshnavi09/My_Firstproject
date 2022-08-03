using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Inheritence
{
    class Car1
    {
        public int model_no;
        public string name;
        public int price;
        public string engine;


        public Car1(int model_no, string name, int price, string engine)
        {
            this.model_no= model_no;
            this.name = name;
            this.price = price;
            this.engine = engine;
        }
        public showcar1()
        {
            Console.WriteLine(" " + model_no + " " + name + " " + price + engine);
        }
        class Engine
        {
            string engine;
            int id;
        
        Engine(int id, string Engine)
        {
                this.id = id;
                this.Engine = Engine;
        }


            void Dsplay Car1()
            {
                Console.WriteLine(id + " " + engine);
            }



    }
}
