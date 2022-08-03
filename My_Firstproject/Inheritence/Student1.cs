using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Inheritence
{
    class student
    {
        private int rollnumber = 1244;
        internal string name = "madhu";
        public string address = "tdp";
        protected int marks = 72;

        private void Rollnumber()
        {
            Console.WriteLine(rollnumber);
        }
        internal void Accept2()
        {
            Console.WriteLine(name);
        }
        public void Accept3()
        {
            Console.WriteLine(address);
        }
        protected void Accept4()
        {
            Console.WriteLine(marks);
        }
        static void Main(string[] args)
        {
            student s = new student();
            s.Rollnumber();
            s.Accept2();
            s.Accept3();
            s.Accept4();
        }

    }
}
    
       
