using System;

namespace Classes
{ //создание экземпляров по слабой ссылке (анонимные объекты) строка 19
    class MyClass
    {
        public void Method()
        {
            Console.WriteLine("Вызван метод класса MyClass");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            new MyClass().Method();   //если надо только 1 раз обратиться к экземпляру

        }
    }
}
