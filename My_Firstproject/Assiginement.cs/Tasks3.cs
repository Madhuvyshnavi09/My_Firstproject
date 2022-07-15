using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Assiginement.cs
{
    class Tasks3
    {

        static void Main(string[]args)
        {
            int  n;
            Console.WriteLine("enter the number");
            n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
                Console.WriteLine(n + "number is even");
            else
                Console.WriteLine(n + " number is odd");
            Console.ReadLine();

        }
    }
}
