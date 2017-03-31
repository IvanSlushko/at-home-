using System;

namespace _010_auto_properties
{
    class Program
    {
        public class Author
    {
        //автоматически реализуемые свойства
        public string Name {get; set; } //даже если в сетере вставить проверку, код сработает
        public string Book { get; set; }
    }
        
        static void Main(string[] args)
        {
            Author author1 = new Author()
            {
                Name = "Petya Goriev",  //блок инициализатора
                Book = "clr via C#"
            };
            Author author2 = new Author()
            {
                Name = "Стив Макконел",  //блок инициализатора
                Book = "Комплит Код"
            };

            Console.WriteLine("Name:  {0}, Book:   {1}", author1.Name, author1.Book);
            Console.WriteLine("Name:  {0}, Book:   {1}", author2.Name, author2.Book);

            Console.ReadKey();


        }
    }
}
