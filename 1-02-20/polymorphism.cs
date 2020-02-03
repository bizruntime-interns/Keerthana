using System;
namespace Animals
{
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("eating");
        }
    }
    public class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("eating bread");
        }

    }
    public class Polymorphism
    {
        public static void Main()
        {
            Animal a = new Dog();
            a.eat();
        }
    }
}