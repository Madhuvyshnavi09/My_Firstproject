using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Basic_test4
{
    class Class1
    {
        static int frequencyDigits(int n,int d)
        {
            int c = 0;
            while(n>0)
            {
                if(n%10==d)
                n = n / 10;
            }
            return c;
        }
        static public void Main(string[]args)
        {
            int N = 1122322;
            int D = 2;


            Console.WriteLine(frequencyDigits(N, D));
        }
    }
}
