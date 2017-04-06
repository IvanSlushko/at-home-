using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Dog
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

    class Cat
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
            dog.Guard();

            cat.Go(); //однотипный объекты
            cat.Eat();


        }
    }
}
