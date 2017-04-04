using System;

namespace Classes
{
    //вторая часть класса
    partial class PartialClass
    {
        //Определение частичного метода
        partial  void PartialMethod()
        {
            Console.WriteLine("Вызван частичный метод - partialMethod ()");

        }
        //вызов частичного метода через метод обертку
        public void CallPartialMethod()
        {
            PartialMethod();
            //при вызове нереализованного частичного метода компилятор его проигнорит
            MyMethod();
        }
        partial void MyMethod()
        {
            Console.WriteLine("реализация частичных методов в других частях класса необязательна");
            Console.ReadKey();
        }

    }
}