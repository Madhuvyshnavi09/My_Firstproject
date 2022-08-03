using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Basic_test4
{
    class Class2
    {
        static void Main(string[] args)
        {
            int i;
            for(i = 1;i<=8;i++)
            {
                Console.WriteLine(i * i - 1);
            }
            int find_nth_term(int n)
            {
                return n * (n + 2);
            }
            int Main()
            {
                int n = 7;
                Console.WriteLine(find_nth_term(n));
                return 0;
            }

        }

    }
}