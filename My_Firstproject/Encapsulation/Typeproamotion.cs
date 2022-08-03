using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Encapsulation
{
    class Typeproamotion
    {
        void Addition(int x,float t)
        {
            Console.WriteLine(x + t);
        }
        static void Main(string[]args)
        {
            Typeproamotion p = new Typeproamotion();
            //p.Addition(4,6.7);
            p.Addition(7, 51);
        }
    }
}
