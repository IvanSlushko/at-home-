using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//объект не может скрывать (инкапсулировать) ничего от другого объекта того же класса 
namespace Classes
{
    class MyClass
    {
        MyClass my = null;
        private void Method()
        {
            Console.WriteLine("private hello");
        }
        public void CallMethod()
        {
            my = new MyClass();
            //private виден на экземпляре
            my.Method();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new Classes.MyClass();
            my.CallMethod();
            //my.Method недопустим
        }
    }
}
