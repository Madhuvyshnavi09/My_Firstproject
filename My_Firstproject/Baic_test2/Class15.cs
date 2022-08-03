using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Baic_test2
{
    class Class15
    {
        static void Main(string[] args)
        {
            int i, j, fact, num, sum = 0;
            Console.WriteLine("enter the last  series");
            num = int.Parse(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                fact = 1;
                if (1 != num)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(" ");
                }
                for (j = 1; j <= 1; j++)
                    fact = fact * j;
                sum = sum + fact;
            }

            Console.WriteLine(sum);
        }     
    }
}
