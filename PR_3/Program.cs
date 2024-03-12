using System;

namespace Classes
{
    class Program
    {
        static void Main()
        {
            Title title = new Title("Будь корисним. Сiм життєвих правил");
            Author author = new Author("Арнольд Шварценеггер");
            Content content = new Content("Iсторiя вiдомого бодибiлдера");

            Book book = new Book(title, author, content);
            book.Show();

            Console.ReadKey();
        }
    }
}