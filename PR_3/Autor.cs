namespace Classes
{
    public class Author
    {
        public string Content { get; set; }

        public Author(string content)
        {
            Content = content;
        }

        public void Show()
        {
            Console.WriteLine($"Автор: {Content}");
        }
    }
}