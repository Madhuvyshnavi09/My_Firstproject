using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Basic_test3
{
    class Cass2
    {
         public static void Main(string[] args)
         {
            long n = 6214325555L;

            if (isvalidIMEI(n))
            {
                Console.WriteLine("valid IMEI code");
            }




            static Boolean isvalidIMEI(long n)
            {
                int length = 15;
                string s = n.ToString();
                //converting the number into
                //string for finding length
                if (length != 15)
                    return false;
                int sumDigit = 0, sum = 0;
                for (int i = length; i >= 1; i--)
                {
                    int d = (int)(n % 10);


                    if (i % 2 == 0)
                        d = 2 * d;

                    sum += sumDigit * d;
                    n = n / 10;

                }
                return (sum % 10 == 0);


                {
                    Console.WriteLine("invalid IMEI code");
                }
            }
        }
    }
}

 