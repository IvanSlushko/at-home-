using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_properties
{
    //использование методов доступа к закрытым полям
    class MyClass
    {
        private string field = null;
        public void SetField (string value)  //mutator setter
        {
            if (value=="Hello 001")
                field="Hello 000001";
                else
            field = value;
        }
        public string GetField()  //accesor  getter
        {
            return field;
        }
            }

        class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance.SetField("Hello 001");    //setter
            string @string = instance.GetField(); //getter
   
            Console.WriteLine(@string);

            Console.ReadKey();

        }
    }
}
