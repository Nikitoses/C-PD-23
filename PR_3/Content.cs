namespace Classes
{
    public class Content
    {
        public string ContentData { get; set; } // Изменено на ContentData

        public Content(string content)
        {
            ContentData = content; // Исправлено на ContentData
        }

        public void Show()
        {
            Console.WriteLine($"Содержание: {ContentData}"); // Исправлено на ContentData
        }
    }
}