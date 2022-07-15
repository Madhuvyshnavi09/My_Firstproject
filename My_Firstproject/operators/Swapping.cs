using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.operators
{
    class Swapping
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 33;
            b = 44;

            Console.WriteLine("before swapping a=" + a +"b= " + b);

            c = a;
            a = b;
            b = c;
            Console.WriteLine("after swapping b=" + b + "a= " + a);


        }
    }
}
