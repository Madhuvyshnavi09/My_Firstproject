using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Inheritence
{
    class Departement
    {
        public int id;
        public string name;

        public Departement(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void showEmployee()
        {
            Console.WriteLine(" " + id + " " + name);
        }

        class Employee
        {
            int id;
            string name;
            int salary;


            Employee(int id, string name, int salary)
            {
                this.id = id;
                this.name = name;
                this.salary = salary;

            }
            void DisplayEmployee()
            {
                Console.WriteLine(id + " " + name);
            }
            static void Main(string[] args)
            {
                Departement s = new Departement(244, "meenu");
                s.showEmployee();


                Employee e;
                e = new Employee(255, "indu", 2500000);
                e.DisplayEmployee();
            }
        }
    }
}

   
        

        
    

