using System;

// Nested structures.

namespace Nested
{
    struct MyStruct
    {
        public struct Nested
        {
            public void Method()
            {
                Console.WriteLine("Nested structure in structure");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            MyStruct.Nested instance = new MyStruct.Nested();
            instance.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
