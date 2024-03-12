using System;

namespace Classes
{
    public class Book
    {
        private Title title;
        private Author author;
        private Content content;

        public Book(Title title, Author author, Content content)
        {
            this.title = title;
            this.author = author;
            this.content = content;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            title.Show();
            Console.ForegroundColor = ConsoleColor.Green;
            author.Show();
            Console.ForegroundColor = ConsoleColor.Red;
            content.Show();
            Console.ResetColor();
        }
    }
}