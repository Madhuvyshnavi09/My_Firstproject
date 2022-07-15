using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Assiginement.cs
{
    class Task9
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("enter first number");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("enter second number");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter third number");
            c = int.Parse(Console.ReadLine());


            if (a > b && a > c)
            {
                Console.WriteLine(a + " is greatest");


            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b + " is greatest");
            }
            else if (c > a && b > c)
            {
                Console.WriteLine(c + " is greatest");
            }
            else
            {
                Console.WriteLine("all are equal");

            }
            Console.ReadLine();
}
            
      

    }
}
