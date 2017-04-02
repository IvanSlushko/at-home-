using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {     
        static void Main(string[] args)
        {

            MoneyEntry me = new MoneyEntry();

            Console.WriteLine("Hello");
            Console.Write("Введите сумму: ");
            string amount = Console.ReadLine();

            Console.Write("Введите дату: ");
            string date = Console.ReadLine();

            me.InitWithString(amount, date);

            Console.WriteLine("Ваша запись: ");
            Console.WriteLine(me.ToString());

            if (me.IsDebit)
                Console.WriteLine("У вас доход.");
            else Console.WriteLine("У вас расход. ");

        }
    }
}
 