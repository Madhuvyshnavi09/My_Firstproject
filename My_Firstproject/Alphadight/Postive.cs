using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Alphadight
{
    class Postive
    {

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("input any number :");
            n = int.Parse(Console.ReadLine());
            if (n >= 0)
            {
                if (n == 0)

                {
                    Console.WriteLine("entered number is zero");
                }
                else
                {
                    Console.WriteLine(n + " is postive ");
                }
            }
            else
            {
                Console.WriteLine(n + " is negative number ");
            }
            Console.ReadLine();
        }
    }
}


           


    

