using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.pricing
{
    class Sales
    {
        static void Main(string[] args)
        {
            int sales = 52000;
            double bill, comm = 0;
            if (sales < 10000)
            {
                Console.WriteLine(comm = (sales * 5) / 100);
            }
            else if (sales >= 10000 && sales < 25000) 
            {
                Console.WriteLine(comm = (sales * 10) / 100);
            }
            else if (sales >= 25000 && sales < 50000)
            {
                Console.WriteLine(comm = (sales * 15) / 100);
            }
           
             else
            {
                Console.WriteLine(comm = (sales * 18) / 100);

            }

            bill = sales - comm;
            Console.WriteLine("comm=" + comm);
            Console.WriteLine("bill=" + bill);

        }
    }
}
