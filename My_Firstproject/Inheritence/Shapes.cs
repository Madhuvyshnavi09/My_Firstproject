using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Inheritence
{
    class Shapes
    {
        int area(int l,int w)
        {
            return (l * w);
        }
        double area(double b,double h)
        {
            return (b * h) / 2;
        }
        int area(int s)
        {
            return (s * s);
        }
         double area (double  r)
         {
            return (3.14 * r * r);
         }
        static void Main(string[]args)
        {
            Shapes e = new Shapes();

            Console.WriteLine("area of rectangle"+ e.area(6,8));
            Console.WriteLine("area of triangle "+ e.area(3,2));
            Console.WriteLine("area of square "+ e.area(8));
            Console.WriteLine("area of circle"+ e.area(4,9));

        }
    }
}
