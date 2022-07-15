using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Assiginement.cs
{
    class Task4
    {

        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("enter the first number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            b = int.Parse(Console.ReadLine());

            if (a > b)

                Console.WriteLine("first number is bigger than second number");
            else if (a < b)
            {
                Console.WriteLine("second number  id bigger than first number");

            }
            else
            {
                Console.WriteLine("both numbers equal");
            }
        }
    
    }
}

