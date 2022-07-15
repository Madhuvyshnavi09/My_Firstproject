using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Nested
{
    class Demo_9
    {

        static void Main(string[]args)
        {
            for (int i=1;i<=4;i++)
            {
                if(i%2!=0)
                {
                    int c = 1;
                    for(char j='A';c<=i;j++)
                    {
                        Console.WriteLine(j);
                        c++;
                    }
                }    else
                {
                    for(int j=1;j<=i;j++)
                    {
                        Console.WriteLine(j);

                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
