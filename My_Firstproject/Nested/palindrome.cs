using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Nested
{
    class palindrome

    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int r, pal;
            pal = num;
            while(num>0)
            {
                r = num % 10;
                sum = (sum * 10) + r;
                num = num / 10;

            }
            if (pal == sum)

                Console.WriteLine("number is palindrome:");
            else
                Console.WriteLine("number is not palindrome:");

        }
    }
}
