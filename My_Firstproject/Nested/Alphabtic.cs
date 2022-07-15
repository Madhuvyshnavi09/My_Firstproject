using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Nested
{
    class Alphabtic
    {
       static void Main(string[]args)
        {
            for(char i='A'; i<='D';i++)
            {
                for(char j='A'; j<=i;j++)
                {
                    Console.Write(j);

                }
                Console.WriteLine();

            }
                    
        }
    }
}
