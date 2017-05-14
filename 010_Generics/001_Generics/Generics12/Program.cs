using System;

// Контрвариантность обобщений.
// Контрвариантность обобщений в C# 4.0 ограничена интерфейсами и делегатами.

namespace Generics
{
    public abstract class Shape { }
    public class Circle : Shape { }

    public interface IContainer<in T> //контрвариантность
    {
        T Figure { set; }
    }

    public class Container<T> : IContainer<T>
    {
        private T figure;

        public Container(T figure)
        {
            this.figure = figure;
        }

        public T Figure
        {
            set { figure = value; }
        }

        public override string ToString()
        {
            return figure.GetType().ToString();
        }
    }

    class Program
    {
        static void Main()
        {
            Shape shape = new Circle();

            IContainer<Circle> container = new Container<Shape>(shape);//параметр приводится к производному типу downcast

            Console.WriteLine(container.ToString());

            // Delay.
            Console.ReadKey();
        }
    }
}
