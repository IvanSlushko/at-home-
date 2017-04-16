using System;

// Структуры.

namespace Structure
{
    struct MyStruct
    {
        public int field;

        // Конструкторы по умолчанию нельзя задавать явно.
        //public MyStruct()
        //{
        //}

        // Если в структуре имеется пользовательский конструктор, то требуется в нем инициализировать все поля.
        public MyStruct(int value)
        {
            Console.WriteLine("Constructor    public MyStruct(int value)");
            this.field = value;
        }
    }

    class Program
    {
        static void Main()
        {
            // Создание экземпляра структурного типа с вызовом конструктора по умолчанию.
            MyStruct instance = new MyStruct();
            MyStruct instance1 = new MyStruct(333);

            Console.WriteLine(instance.field);
            Console.WriteLine(instance1.field);
            // Delay.
            Console.ReadKey();
        }
    }
}
