using System;

// Наследование. 

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            DerivedClass instance = new DerivedClass();

            Console.WriteLine(instance.publicField);
            
            instance.Show();// показываем закрытое поле через открытый метод

            // Delay.
            Console.ReadKey();
        }
    }
}
