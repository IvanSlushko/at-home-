using System;

// Структуры. Статический конструктор.

namespace Structure
{
    struct MyStruct
    {
        public int field;

        // Статический конструктор всегда отрабатывает первым.
        static MyStruct()
        {
            Console.WriteLine("Static Constructor");
        }

        // Если в структуре имеется пользовательский конструктор, то требуется в нем инициализировать все поля.
        public MyStruct(int value)
        {
            Console.WriteLine("Constructor");
            this.field = value;
        }
    }

    class Program
    {
        static void Main()
        {
            // Создание экземпляра структурного типа, с вызовом пользовательского конструктора.
            MyStruct instance = new MyStruct() { field = 555 }; //с этим не отработают статич и пользовательский конструкторы, только по умолчанию!!
            MyStruct instance1 = new MyStruct(33);  //c этим оба отработают
            Console.WriteLine("----------------");
            Console.WriteLine(instance.field);
            Console.WriteLine(instance1.field);
            // Delay.
            Console.ReadKey();
        }
    }
}
