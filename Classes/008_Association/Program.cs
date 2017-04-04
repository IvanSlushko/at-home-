using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Association
{
    class MyClass1
    {
        public MyClass1()
        {
            Console.WriteLine("создан экз класса май класс 1");
        }
    }
    class MyClass2
    {
        private MyClass1 myObj = null;
        //это не фабричный метод
        public void Method()
        {
            myObj = new MyClass1();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass2 my = new MyClass2();
            my.Method();

        }
    }
}
