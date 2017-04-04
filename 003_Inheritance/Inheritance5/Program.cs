using System;

// Приведение к базовому типу.

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            DerivedClass instance = new DerivedClass();

            instance.field1 = 1;
            instance.field2 = 2;
            instance.field3 = 3;

            instance.field4 = 4;
            instance.field5 = 5;
            
            Console.WriteLine(instance.field1);
            Console.WriteLine(instance.field2);
            Console.WriteLine(instance.field3);
            Console.WriteLine(instance.field4);
            Console.WriteLine(instance.field5);
            Console.WriteLine("-----");

            // Приведение экземпляра класса DerivedClass к базовому типу BaseClass.
            BaseClass newInstance = (BaseClass)instance; // Upcast

            Console.WriteLine(newInstance.field1);
            Console.WriteLine(newInstance.field2);
            Console.WriteLine(newInstance.field3);

            //Console.WriteLine(newInstance.field4);
            //Console.WriteLine(newInstance.field5);

            Console.WriteLine("-----");
            // Проверка.
            Console.WriteLine("instance Id     {0}", instance.GetHashCode());
            Console.WriteLine("newInstance Id  {0}", newInstance.GetHashCode());
            //коды РАВНЫ!! это один и тот же объект!

            // Delay.
            Console.ReadKey();
        }
    }
}
