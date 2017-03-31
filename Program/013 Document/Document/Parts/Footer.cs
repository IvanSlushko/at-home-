using System;

namespace Classes
{
    class Footer
    {
        string content;


        public string Content
        {
            get
            {
                if (content != null)
                    return content;
                else return "нижний колонтитул отсутствует.";
            }

            set
            {
                content = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
