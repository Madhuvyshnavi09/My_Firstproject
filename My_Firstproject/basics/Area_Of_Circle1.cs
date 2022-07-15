using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.basics
{
    class Area_Of_Circle1
    {
        static void Main(string[] args)
        {
            int r;
            double s;
            Console.WriteLine("Enter the radius");
            r = Convert.ToInt32(Console.ReadLine());
            s = (3.14) * r * r;
            Console.WriteLine("the area of circle of given radius is=" + s);
            Console.ReadKey();
        }
    }
}
