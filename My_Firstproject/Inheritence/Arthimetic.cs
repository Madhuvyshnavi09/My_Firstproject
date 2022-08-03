using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Inheritence
{
    class Arthimetic

    {
        int Calculator(int a, int b)
        {
            return a + b;

        }
        float Calculator(float a, float b)
        {
            return a - b;
        }
        double Calculator(double a, double b)
        {
            return a * b;
        }
        double Calculator(int a ,double b)
        {
            return a % b;
        }
        static void Main(string[] args)
        {
            Arthimetic c = new Arthimetic();
            Console.WriteLine("addition" + c.Calculator(4, 6));
            Console.WriteLine("subtraction" + c.Calculator(6, 5));
            Console.WriteLine("multiplication" + c.Calculator(4, 6));
            Console.WriteLine("division" + c.Calculator(4, 6));

        }
    }
}
       
        




        