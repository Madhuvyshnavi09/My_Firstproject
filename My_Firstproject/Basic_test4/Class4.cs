using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Basic_test4
{
    class Class4
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = i; j >= 1; j--)
                    Console.Write(j);
                Console.WriteLine();
            }
        }
    }
}
    

