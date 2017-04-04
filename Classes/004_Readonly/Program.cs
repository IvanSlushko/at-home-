using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Readonly
{
    class Program
    {
        //поле только чтение устанавливается только конструктором
        public readonly string field = "hell";
        //конструктор
        public Program()
        {
            field = "this field read only ";
            field += "!!!";
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.field);

            //program.field =  "пробую записать в это поле";
            
        }
    }
}
