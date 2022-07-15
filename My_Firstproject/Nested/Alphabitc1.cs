using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Nested
{
    class Alphabitc1
    {
        static void Main(string[]args)
        {
            for(char i='A';i<='C';i++)
            {
                for(char j='A';j<=i;j++)
                {
                    Console.Write(j);

                }
            }     Console.WriteLine();
        }
    }
}
