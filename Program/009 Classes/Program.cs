using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Classes
{
    class MyClass
    {
        public void Method()
        {
            Console.WriteLine(" вызван метод класса MyClass");
        }
    }
    class MyClass2
    {
        public void CallMethod(MyClass my)  //этот метод принимает один аргумент типа май класс и ничего не возвращает
        {
            my.Method();//вызываем метод с именем МЕТОД аргумента МУ
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            MyClass2 my2 = new MyClass2();
            my2.CallMethod(my);
            Console.ReadKey();
        }
    }
}
