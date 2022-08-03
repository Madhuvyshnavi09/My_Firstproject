using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Inheritence
{
    class Teacher
    {
        string name;
        string qualification;
        int experience;
        long mobile;

        public Teacher(string name, string qualification, int experience, long mobile)
        {
            this.name = name;
            this.qualification = qualification;
            this.experience = experience;
            this.mobile = mobile;
        }
        public Teacher()
        {

        }
        public void setName(string name)
        {
            this.name = name;

        }
        public string getName()
        {
            return this.name;
        }
        public void setExperience(int e)
        {
            this.experience = e;

        }
        public int getexperience()
        {
            return experience;
        }
    }
    class permanentTeacher : Teacher
    {
        int salary;
        public void display()
        {
            Console.WriteLine(salary);
            Console.WriteLine(getName());
        }
        static void Main(string[] args)
        {
            permanentTeacher p1 = new permanentTeacher();

            p1.setName("keerthi");
            A ob = new A();
            ob.X = 900;
            ob.Name = "deepa";
            Console.WriteLine(ob.X + " " + ob.Name);
        }
    }
    class A
    {
        int x;
        string name;


        public int X
        {
            get { return x; }
            set { Console.WriteLine("insetter of x"); this.x = value; }
        }

        public string Name { get => Name; set => Name = value; }

    }

}



            
            
     








