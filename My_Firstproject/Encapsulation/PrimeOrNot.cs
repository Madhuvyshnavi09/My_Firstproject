using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Encapsulation
{
    class PrimeOrNot
    {
        internal int id;
        internal string name;
        internal int salary;

        PrimeOrNot(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
        static void Main(string[] args)
        {
            PrimeOrNot emp = new PrimeOrNot(1, "meenu", 50000);

            emp.display();

        }
    }
    class Order
    {
        int oid;
        string product_name;
        int price;
        int qty;

        Order(int oid,string product_name,int qty,int price)
        {
            this.oid = oid;
            this.product_name = product_name;
            this.qty = qty;
            this.price = price;
           
        }
        Order()
        {
           // total_bill = price * qty;\\
        }
        void display()
        {
           // Console.WriteLine(oid + " " + product_name + " " + price + " " + qty + " " + total_bill);\\
        }
        static void Main(string[]args)
        {
            Order r = new Order(1, "pen_drive", 2, 500);
        }
    }
    
}


   

