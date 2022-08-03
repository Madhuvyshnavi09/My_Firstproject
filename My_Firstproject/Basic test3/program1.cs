using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Basic_test3
{
    class program1
    {

            static void Main(string[] args)
            {
                Console.WriteLine(" divided by 5&10");
                for (int i = 1; i < 100; i++)
                {
                    if (i % 5 != 0 && i % 10 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.ReadKey();
            }
        }
    }

