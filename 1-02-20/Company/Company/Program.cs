using System;

namespace Company
{
    public class Employee
    {
        public float salary = 50000;
    }
    class Details : Employee
    {
        public string name = "Arun";
        public int age = 25;
        public string skill = "Python";
    }
    class Manager
    {
        static void Main(string[] args)
        {
            Details d = new Details();
            Console.WriteLine("Name:"+d.name);
            Console.WriteLine("Age:"+d.age);
            Console.WriteLine("Skill:"+d.skill);
            Console.WriteLine("Salary:"+d.salary);
        }
    }
}
