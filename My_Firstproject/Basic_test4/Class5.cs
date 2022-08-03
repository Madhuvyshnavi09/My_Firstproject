using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Basic_test4
{
    class Class5
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write(j % 2);
                Console.WriteLine();
            }
        }
    }
}
  

