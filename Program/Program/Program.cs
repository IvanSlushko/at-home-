using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Butterfly mahaon = new Butterfly();
            mahaon.name = "Admiral";
            mahaon.Fly();
            


            MyClass instance = new MyClass();
            instance.field = "Hello wova))";

            Console.WriteLine(instance.field);
            instance.Method();



            Console.ReadKey();
        }
    }
    class Butterfly
    {
        public string name;
        public void Fly()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("fLY {0} !!!!", i);
            }
        }
   
    }
    class MyClass
    {
        public string field;
        public void Method()
        {
            Console.WriteLine(field);
        }
    }
}