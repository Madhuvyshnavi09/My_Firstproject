using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Encapsulation
{
    class Class2
    {
        static void Main(string[]args)
        {
            int i, num, sum = 0;
            Console.WriteLine("enter a number:");
            num = Convert.ToInt32(Console.ReadLine());

            for(i=2;i<=num;i++)
            {
                if (1 % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("total sum of all even number less than" + num + " is:" + sum);
                  
        }
    }
}
