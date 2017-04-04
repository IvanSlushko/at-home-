using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//самоассоциация
namespace Classes
{
    class Program
    {
        public void Method()
        {
            Console.WriteLine("hi");
        }
        static void Main(string[] args)

        {
            Program progran = new Program();
            progran.Method();
        }
    }
}
