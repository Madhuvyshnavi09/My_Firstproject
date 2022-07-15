using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Alphadight
{
    class Blood
    {
        static void main(string[]args)
        {
            Console.WriteLine("enter a age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a weight");
            int wt = int.Parse(Console.ReadLine());
              

            if(age >18 && wt>50)
            {
                Console.WriteLine("the person is valid for blood donation");

            }
            else
            {
                Console.WriteLine("the person is not valid for blood donation try next time...");


            }
        }
    }
}
