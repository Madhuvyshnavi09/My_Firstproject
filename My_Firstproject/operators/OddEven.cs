using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.operators
{
    class OddEven
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
                Console.WriteLine(n + " is even");
            else
                Console.WriteLine(n + "is odd");
            Console.ReadKey();
        }
    }
}
