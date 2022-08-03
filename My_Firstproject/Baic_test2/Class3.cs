using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Baic_test2
{
    class Class3
    {
        static void Main(string[]args)
        {

            int i = 1,K = 1;
            while(i++<=5)
            {
                K = K*i;
            }
            Console.WriteLine("k=" + K + "i=" + i);
        }
    }
}
