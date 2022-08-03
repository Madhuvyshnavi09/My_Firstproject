using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Baic_test2
{
    class Class8
    {
        static void Main(string[]args)
        { 
            int i;
          for (i = 5;  i>=1;i--)
            {
                for (int j = 1; j <= 5 - i; i++)
                {
                    Console.Write(" ");
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write(k);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
