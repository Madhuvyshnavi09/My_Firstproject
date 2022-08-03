using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Inheritence
{
    class Class_Program
    {
        void area(int side)
        {
            Console.WriteLine("square" + side * side);

        }
        static void area(float r)
        {
            Console.WriteLine("Area of circle" + 3.14f * r * r);
        }
        static void area(int l,int b)
        {
            Console.WriteLine("Area of of rectangle" + l * b);
        }
        void m1(int a,float x)
        {

        }
        void m1(float a,int b)
        {

        }

        static void Main(string[]args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();

            // p.area(10);
            //p.area(3.6f);
            //p.area(3,6);
           // Program.area(10);

           
            
        }
    }
}
