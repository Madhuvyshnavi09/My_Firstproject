using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Nested
{
    class Amstrong
    {
        static void Main(string[]args)
        {
            int num, temp, sum = 0, rem;
            Console.WriteLine("enter a number:");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while(num>0)
            {
                rem = num % 10;
                sum = sum + rem * rem * rem;
                num = num / 10;

            }
            if (temp == sum)
            {
                Console.WriteLine("amstrong number");
            }
            else
                Console.WriteLine("not  a amstrong number");
        }

    }
}
