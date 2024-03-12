namespace Classes
{
    public class Title
    {
        public string Content { get; set; }

        public Title(string content)
        {
            Content = content;
        }

        public void Show()
        {
            Console.WriteLine($"Название книги: {Content}");
        }
    }
}