using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Encapsulation
{
    class Class1
    {
        static void Main(string[]args)
        {
            int num, sum = 0,firstdigit,lastdigit;

            Console.WriteLine("enter any number:");
            num = Convert.ToInt32(Console.ReadLine());

            lastdigit = num % 10;
            firstdigit = num;
            while(num>=10)
            {
                num = num / 10;
            }
            firstdigit = num;

            sum = firstdigit + lastdigit;


            Console.WriteLine("sum of first and last digit:"+sum);

            Console.ReadLine();

        }
    }
}
