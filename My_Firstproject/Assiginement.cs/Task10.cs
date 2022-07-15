using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Assiginement.cs
{
    class Task10
    {
        static void Main(string[]args)
        {
            int n;
            Console.WriteLine("enter the number\n");
            n = int.Parse(Console.ReadLine());
             

            if(n%5==0)
            {
                Console.WriteLine("\n is divisible by 5");
            }
            else
            {
                Console.WriteLine("\n is not divisible by 5");
            }
            Console.ReadLine();
        }
    }
}
