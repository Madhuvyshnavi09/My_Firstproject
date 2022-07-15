using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Alphadight
{
    class Swap_Three_variable
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter the values for A and B");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("A=" + a + " B=" + b);
            a = a + b;
            b = a - b;
            a = a - b;

        }
    }
}
