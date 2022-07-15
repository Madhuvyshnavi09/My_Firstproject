using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Alphadight
{
    class Percentage
    {
        static void Main(string[] args)
        {
            int total, Average, Percentage;

            Console.WriteLine("enter Average for subject s1");
            var s1 = Console.ReadLine();
            Console.WriteLine("enter Average for subject s2");
            var s2 = Console.ReadLine();
            Console.WriteLine("enter Average for subject s3");
            var s3 = Console.ReadLine();
            Console.WriteLine("enter Average for subject s4");
            var s4 = Console.ReadLine();
            Console.WriteLine("enter Average for subject s5");
            var s5 = Console.ReadLine();


            total = Convert.ToInt32(s1) + Convert.ToInt32(s2)
                    + Convert.ToInt32(s3) + Convert.ToInt32(s4)
                    + Convert.ToInt32(s5);
                    Average = 100;
            Percentage = total * 100 / Average;
            Console.WriteLine("%" + Percentage);


            /* console.writeline("enter the percentages");
             * int  marks = convert.ToInt32(Console. Readlin());*/
            if (Percentage > 70)
            {
                Console.WriteLine("pass with distrinction");
            }
            else if (Percentage > 60 && Average < 70)
            {
                Console.WriteLine("pass with first class");

            }
            else if (Percentage > 50 && Average < 60)
            {
                Console.WriteLine(" pass second class");
            }
            else if (Percentage > 35 && Average < 50)
            {
                Console.WriteLine(" pass third class");

            }
            else if (Percentage < 35 && Average > 35)
            {
                Console.WriteLine("fail");

            }
        }
    }
}
