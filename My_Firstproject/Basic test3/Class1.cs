using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Basic_test3
{
    class Class1basic
    {
        static void Main(string[]args)
        {
            for(int i=1;i<100;i++)
            {
                if (i % 5 == 0 || i % 10 == 0)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
