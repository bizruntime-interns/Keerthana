using System;

namespace Company
{
    class Employees
    {
        public void departments(ref int Salary)
        {
            Salary = 5000;
            Console.WriteLine("Salary of the employee :"+ Salary);
        }

        static void Main(string[] args)
        {
            int Salary = 3000;
            Employees e = new Employees();
            Console.WriteLine("Salary of the employee at the start:"+ Salary);
            e.departments(ref Salary);
            Console.WriteLine("Salary of the employee after an year:" + Salary);
        }
    }
}
