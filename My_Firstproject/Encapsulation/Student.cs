using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Encapsulation
{
    class Student
    {

        int id;
        private string name;
        private int percentage;
        private string placement;
        private string type;


        public  string Name
        {
            get { return name;}
            set { name = value;}
        }
        public int Percentage
        {
            get { return percentage; }
            set { percentage= value;}
        }
        public String Placement
        {
            get { return placement;}
            set { placement = value; }
        }
        public String Type
        {
            get { return type;}
            set { type = value; }
        }
        class studentinfo
        {
            static void Main(string[]args)
            {
                Student e = new Student();
                e.name = "meenu";
                e.placement = "cts ";
                e.type = "testing";

            }
        }
    }
}
