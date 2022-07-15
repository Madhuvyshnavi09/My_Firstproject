using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Looping
{
    class BreakContinues
    {

        static void Main(string[]args)
        {
            for(int i=1;i<=5;i++)
            {
                if(i==3)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
