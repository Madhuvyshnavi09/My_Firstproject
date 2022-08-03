using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Encapsulation
{
    class Prime
    {
        bool isprimeNumber(int n)
        {
            bool isprime = true;
            for(int i=2;i<n;i++)
            {
                if(n%i==0)
                {
                    isprime  = false;
                    break;
                }
            }
            return isprime;
       
        }
        static void Main(string[]args)
        {
            // check prime p = new  isprime();\\
            //bool  b = p.IsprimeNumber(9);\\
           // if(b==true)\\
            {
                Console.WriteLine("prime");
            }
            {
                Console.WriteLine("not prime");
            }
        }
    }
}
