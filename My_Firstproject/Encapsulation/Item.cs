using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Encapsulation
{
    class Item
    {
        internal int id;
        internal string name;
        internal int cost;


        Item(int id, string name, int cost)
        {
            this.id = id;
            this.name = name;
            this.cost = cost;
            //this.Display();\\
            this.show();
            //show;



        }
        public void show()
        {
            Console.WriteLine(id + " " + name + " " + cost);

        }
        class ThisUse
        {

            static void Main(string[] args)
            {
                  Item e = new Item(524, "soap", 550);
                  //e.Display();\\

                // Bike b = new Bike();
                // b.AAceeptDetails(564, "Bulllet", 50000);\\
            }

        }
    }
}

          


        

      
            

           



       
    

