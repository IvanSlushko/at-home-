namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Title title = new Title();
            title.Content = "Contract";

            Body body = new Body();
            body.Content = "Telo kontrakta......";
                           
            Footer footer = new Footer();
            footer.Content = "Direktor Ivanov Q.W.";

            Document document = new Document(title, body, footer);
            document.Show();

        }
    }
}
