using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Constructors
{
    class Point
    {
        //поля
        private int x, y;
        //свойства
        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }
        //конструктор поумолчанию, инициализирует поля по умолчанию (объявленные вверху)
        public Point()
        {
            Console.WriteLine("конструктор по умолчанию!!!");
        }
        //пользовательский конструктор, инициализирует поля значениями, заданными пользователем
        public Point(int x, int y)
        {
            Console.WriteLine("пользовательский конструктор!!!");
            this.x = x; //ссылка на себя THIS!!!!!! 
            this.y = y;
         }
    }
}
