using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Basic_Test1
{
    class Program_1
    {

        static void Main(string[]args)
        {
            double side, area;
            Console.WriteLine("enter the length of side of equilateral  triangle\n");
             side = Convert.ToDouble(Console.ReadLine());
           //area of equilateral triangle=sqrt(3)/4*side*side//
            area = (3) / 4 *side;
            Console.WriteLine("Area of triangle", area);
            Console.ReadLine();
        }
    }
}
