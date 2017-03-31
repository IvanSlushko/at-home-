using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //применение конструктора по умолчанию
            Point pointA = new Point();
            Console.WriteLine("pointA.X = {0}  pointA.Y= {1}", pointA.X, pointA.Y);
            Console.WriteLine(new string('-', 50));

            //применение конструктора с параметрами
            Point pointB = new Point(100,200);
            Console.WriteLine("pointB.X = {0}  pointB.Y= {1}", pointB.X, pointB.Y);

        }
    }
}
