using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Baic_test2
{
    class Class12
    {
        static void Main(string[]args)
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    
                        Console.WriteLine(i);
                    
                }
                else
                    Console.WriteLine(-1 * i);
            }
        }
    }
}
