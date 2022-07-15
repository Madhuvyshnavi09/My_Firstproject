using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Looping
{
    class Addition
    {

        static void Main(string[] args)
        {
            //print addition of even number between 1 to 20
            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {

                if (i % 2 == 0)
                {
                    sum = sum + 1;

                }
                Console.WriteLine(sum);
            }
        }
    }
}
