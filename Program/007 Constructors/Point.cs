using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Constructors
{
    //конструктор может вызввать в том же самом объекте другой конструктор
    //с помощью ключевого THIS
    class Point
    {
        //поля
        private int x, y;
        private string name;
        //свойства
        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }
        public string Name
        {
            get { return name; }
        }
        // использование this в констр с 1 параметром с 37 строки
        //приводит к вызову этого конструктора
        public Point(int x,int y)
        {
            Console.WriteLine("конструктор с 2 параметрами.");
            this.x = x;  
            this.y = y;
        }
        //использование this вызывает констр с 2 параметрами с 30 строки
        public Point(string name)
            :this (300,400)
        {
            Console.WriteLine("конструктор с 1 параметром.");
            this.name = name; 
         }
    }
}
