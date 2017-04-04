using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//самоассоциация
namespace _006_SelfAssociation
{
    class MyClass
    {
        MyClass instance;

        public MyClass()//stackOverflowExept
        {
            Console.WriteLine("construktor MyClass");
            //самоассоциация приводит к цикличному инстанцированию
            instance = new MyClass();
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            //попытка инстанцировать myClass
            MyClass instance = new MyClass();

        }
    }
}
  