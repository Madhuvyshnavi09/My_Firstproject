using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Nested
{
    class Demo_6
    {
        static void Main(string[]args)
        {
            int i, j;
            for (i = 1;i<=4;i++)
            {
                for(j=4;j>=i;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
