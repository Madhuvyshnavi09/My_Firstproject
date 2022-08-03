using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Encapsulation
{
    class Item1
    {
        int Iid;
        string name;
        int cost;
        int qty;
        int total_bill = 0;
        int price;

        Item1(int Iid, string name, int cost, int qty):this()
        {
            this.Iid = Iid; 
            this.name = name;
            this.cost = cost;
            this.qty = qty;
            this.Display();

        }
        Item1()
        {
            total_bill = price * qty;
        }
        void Display()
        {
            Console.WriteLine(Iid + "" + name + " " + cost + " " + qty);
        }
        static void Main(string[] args)
        {
            Item1 r = new Item1(2, " saops", 550,5);

        }
        

    }
}
