using System;

namespace Inheritance
{
    class DerivedClass : BaseClass
    {
        // Замещение метода базового класса.

        public void Method()//имя как в базовом
        {
            Console.WriteLine("Method from DerivedClass");
        }
    }
}
