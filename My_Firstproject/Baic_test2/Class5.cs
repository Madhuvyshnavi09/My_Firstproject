using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Baic_test2
{
    class Class5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(" enter number");
            int num1 = int.Parse(Console.ReadLine());

            bool isprime = true;
            for (int i = 2; i < num; i++) ;
            {
                if ((num % 1 == 0) && (num % 11 == 0))
                {
                    isprime = false;
                }
            }
            if (isprime == true)
            {
                Console.WriteLine("not prime");
            }
            else
            {
                Console.WriteLine("is prime");
            }
            if (num1 == 2 || num1 - num == 2)
            {
                Console.WriteLine("twinprime");
            }
            else
            {
                Console.WriteLine("not twin prime");
            }
        }
    }
} 


               











