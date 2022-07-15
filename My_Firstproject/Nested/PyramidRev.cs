using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Nested
{
    class PyramidRev
    {

        static void Main(string[]args)
        { int i, j;
            int n = 4;//size
            int z = n * 2 - 1;//print to control
            for(i=n;i>=1;i--)
            {
                for(j=n-1;j>=i;j--)
                {
                    Console.Write("*");
                }
                z -= 2;
            } Console.WriteLine();
        
        }

    }
}
