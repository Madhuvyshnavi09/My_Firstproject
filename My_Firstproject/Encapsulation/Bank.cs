using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Encapsulation
{
    class Bank
    {
        int account_number;
        string account_name;
        int balanace;


        public int Account_Number
        {
            get
            {
                return account_number;
            }
            set
            {
                account_number = value;
            }
           
        }
        public string Account_name
        {
            get
            {
                return account_name;
            }
            set
            {
                account_name = value;
            }
        }
        public int Balance
        {
            get
            {
                return Balance;
            }
            set
            {
                balanace = value;
            }
        }
        class Bnkinfo
        {
            static void main(string[]args)
            {
                Bank b = new Bank();
                b.Account_Number = 8656;
                b.Account_name = "meenu";
                b.Balance = 41000;

                Console.WriteLine(b.Account_Number + " " + b.Account_name + " " + b.Balance);

            }
        }

    }
}
