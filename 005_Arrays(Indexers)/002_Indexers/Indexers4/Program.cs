using System;

// Индексаторы.

namespace Indexers
{
    class Program
    {
        static void Main()
        {
            MyClass my = new MyClass();

            my[1, 1] = 2;//set

            Console.WriteLine(my[1, 1]);//get
            Console.WriteLine(my[0, 0]);//get

            // Delay.
            Console.ReadKey();
        }
    }
}
