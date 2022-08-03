using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Baic_test2
{
    class Class6
    {
        static void Main(string[] args)
        {
            int num, i, j, fact, sum = 0;
            Console.WriteLine("enter tha last series");
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
                    Console.Write(" ");
                }
                for (j = 1;  j<=i; j++)
                    fact = fact * j;
                sum = sum + fact;
            }
            Console.WriteLine(sum);

        }
      }
   }
   