using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Inheritence
{
    class Loan1
    {
        float principal_amount;
        float rate_of_intrest;
        int days;
        float intrest;
        float intrest2;

        int calculate_loan(float principal_amount, float rate_of_intrest,int days)
        {
            intrest = principal_amount * rate_of_intrest - intrest * days / 100;
            return (int)intrest;
        }
        float calculate_loan(float principal_amount,float rate_of_intrest1,float rate_of_intrest2,float intrest,int days)
        {
            if(days>=183)
            {
                intrest2 = principal_amount * rate_of_intrest * days / 100;
            }
            else
            {
                intrest2 = principal_amount * rate_of_intrest2 * days / 100;
            }
            return (int)intrest2;
        }
        static void Main(string[]args)
        {
            Loan1 c= new Loan1();
            float a;
            a=c.calculate_loan(2000000, 0.5f, 365);
            c.calculate_loan(100000, 0.6f, 0.4f, 365,55);

            Console.WriteLine(a);


        }

    }
}
