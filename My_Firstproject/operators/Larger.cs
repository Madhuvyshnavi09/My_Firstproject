using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.operators
{
    class Larger
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 2nd number");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("num1 is greater" + num2);
            }
            else
            {
                Console.WriteLine("num2 is greater" + num1);
            }

        }







    }
}
