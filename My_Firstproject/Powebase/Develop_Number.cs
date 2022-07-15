using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Powebase
{
    class Develop_Number
    {
        static void Main(string[] args)
        {
            //console.writeline (math path(1,9));
            Console.WriteLine("enterthe base");
            int base_number = int.Parse(Console.ReadLine());
            Console.WriteLine("enter exponent");
            int expo = int.Parse(Console.ReadLine());
            int power = 1;
            for (int i = 1; i <= expo; i++)
            {
                power = power * base_number;

            }
            Console.WriteLine(power);
        }
    }
}

    

    

