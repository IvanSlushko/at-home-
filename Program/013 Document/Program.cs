using System;
using Classes;
    class Program
    {
        static void Main(string[] args)
        {

        Document document = new Document("Contract");

            document.Body = "Telo kontrakta......";
            document.Footer = "Direktor Ivanov Q.W.";
            document.Show();
        }
    }
