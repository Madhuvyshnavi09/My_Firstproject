﻿using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Basic_test3
{
    class Reverese
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            int reverse = 0;
            while(num>0)
            {
                int r = num % 10;
                reverse = reverse * 10 + r;
                num = num / 10;
            }
            Console.WriteLine(reverse);
        }
    }
}
