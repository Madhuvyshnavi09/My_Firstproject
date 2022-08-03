using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.oops
{
    class Vechicle
    {
        public int model;
        public string type;
        public int wheels;


        public void AccepDetails(int emodel, string evechicle, int ewheels)
        {
            model = emodel;
            type = evechicle;
            wheels = wheels;



        }
        public void Display()
        {
            Console.WriteLine(model + " " + type + " " + wheels);
        }

        static void Main(string[] args)
        {
            Vechicle e = new Vechicle();
            Console.WriteLine("enter model");
            int emodel = int.Parse(Console.ReadLine());
            Console.WriteLine("enter type");
            string etype = (Console.ReadLine());
            Console.WriteLine("enter wheels");
            int ewheels = int.Parse(Console.ReadLine());
            e.AccepDetails(emodel, etype, ewheels);
            
        }
        public void Average()
        {
            if (wheels == 4)
            {
                Console.WriteLine("average is 15");
            }
            else if (wheels == 2)
            {
                Console.WriteLine("average is 45");
            }
            else if (wheels == 8)
            {
                Console.WriteLine("average is 20");
            }
        }

            public void display()
            {
            Console.WriteLine(model +" " + type + " " + wheels);
            }
            static void main(string[]args)
            {
                Vechicle v = new Vechicle();
                v.AccepDetails(25625, "car", 2);


                 v.Display();
                 v.Average();
            }


        
    }
}
    
      



           
               
    





            

        
        
        






    



        

    
    
