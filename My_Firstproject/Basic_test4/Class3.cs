using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Basic_test4
{
    class Class3
    {
        static bool iskaprekar(int n)
        {
            if (n == 1)
                return true;

            int sq_n = n * n;
            int count_digits = 0;
            while (sq_n != 0)
            {
                count_digits++;
                sq_n /= 10;
            }
            sq_n = n * n;

            for (int r_digits = 1; r_digits < count_digits; r_digits++)
            {

                int eq_parts = (int)Math.Pow(10, r_digits);
                if (eq_parts == n)
                    continue;
                int sum = sq_n / eq_parts + sq_n % eq_parts;
                if (sum == n)
                    return true;
            }
            return false;
        }

        static bool kaprekar(int n)
        {
            if (n == 1)
                return true;
            int sq_n = n * n;
            int count_digits = 0;
            while (sq_n != 0)
            {
                count_digits++;
                sq_n /= 10;
            }

            for (int r_digits = 1; r_digits < count_digits;
                                                r_digits++)
            {

                int eq_parts = (int)Math.Pow(10, r_digits);

                if (eq_parts == n)
                    continue;


                int sum = sq_n / eq_parts + sq_n % eq_parts;
                if (sum == n)
                    return true;
            }


            return false;
        }


        public static void Main()
        {

            Console.WriteLine("Printing first few " + "Kaprekar Numbers using kaprekar()");

            for (int i = 1; i < 10000; i++)
                // if (kaprekar(i))\\
                Console.Write(i + " ");
        }
    }
}




   
