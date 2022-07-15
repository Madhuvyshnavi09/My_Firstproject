using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Nested
{
    class Demo_3
    {

        static void Main(string[] args)
        {
            for (char i = 'D'; i >= 'A'; i--)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.WriteLine(j);
                }
                Console.WriteLine();
            }

        }
    }
}
