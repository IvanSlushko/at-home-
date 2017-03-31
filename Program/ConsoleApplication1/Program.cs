using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MyClass
    {

        private string field = null;
        public string Field
        {
            get
            {
                return field;
            }

            set
            {
                field = value;
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance.Field = "Hell 003";
            Console.WriteLine(instance.Field);
            Console.ReadKey();




        }
    }
}
