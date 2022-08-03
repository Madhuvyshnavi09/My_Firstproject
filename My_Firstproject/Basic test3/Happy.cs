using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Basic_test3
{
    class Happy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number");
            int num = int.Parse(Console.ReadLine());
            bool flag = true;
            while (num > 0)
            {
                int r = num % 10;
                if (r % 2 == 0)
                {

                    flag = false;
                    break;
                }
                num = num / 10;
            }
            if (flag == true)
            {
                Console.WriteLine("Happy");

            }
            else
            {
                Console.WriteLine("NotHappy");
            }
        }
            

            

  

    }
}
