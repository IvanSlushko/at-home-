using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_properties
{

    class MyClass
    {

        private string field = null;
        public string Field
        {
            set
            {
                if (value == "fool")
                    Console.WriteLine("введено недопустимое значение, повторите попытку ");
                else
                field=value;
            }

            get
            {
                if (field == null)
                    return "в поле field нет данных";
                else if (field == "Hello")
                    return field.ToUpper() + "!!!!!!!!!!!!";
                else return field;

                        }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {

            MyClass instance = new MyClass();

            instance.Field = "fool";
            Console.WriteLine(instance.Field);

            Console.WriteLine(new string('-', 50));
            
            instance.Field = "Hello";
            Console.WriteLine(instance.Field);

            //delay
            Console.ReadKey();



        }
    }
}
