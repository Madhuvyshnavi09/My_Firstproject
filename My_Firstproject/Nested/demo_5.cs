﻿using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Nested
{
    class demo_5
    {
        static void Main(string[]args)
        {
            
            for(int  i=1;i<=4;i++)
            {
                for(int k=4;k>=i;k--)
                {
                    Console.Write(" ");
                }
                 for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }Console.WriteLine();
                 

            }
        }
    }
}
