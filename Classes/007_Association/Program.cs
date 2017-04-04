using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//использование техники фабричных методов
namespace _007_Association
{
    class Product
    {
        public Product()
        {
            Console.WriteLine("созданн экз класса продукт");
        }
    }
    class Factory
    {
        public Product FactoryMethod()
        {
            return new Product();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            Product product = factory.FactoryMethod();

        }
    }
}
