using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface IGoEater
    {
        void Go();
        void Eat();
    }
    class Dog:IGoEater 
    {
        public void Go()
        {
            Console.WriteLine("dog step");
        }
        public void Eat()
        {
            Console.WriteLine("dog eat");
        }
        public void Guard()
        {
            Console.WriteLine("dog guard");
        }
    }

    class Cat:IGoEater
    {
        public void Go()
        {
            Console.WriteLine("cat step");
        }
        public void Eat()
        {
            Console.WriteLine("cat eat");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            dog.Go(); //однотипный объекты
            dog.Eat();
            //dog.Guard();

            cat.Go(); //однотипный объекты
            cat.Eat();

            Console.WriteLine("------------");
            IGoEater dog1 = new Dog();
            dog1.Eat();
            dog1.Go();

        }
    }
}
