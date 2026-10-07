namespace Task09
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }

    class PaperBook : Book
    {
        public int Pages { get; set; }

        public PaperBook(
            string title,
            string author,
            int pages)
            : base(title, author)
        {
            Pages = pages;
        }
    }

    class EBook : Book
    {
        public double FileSize { get; set; }

        public EBook(
            string title,
            string author,
            double fileSize)
            : base(title, author)
        {
            FileSize = fileSize;
        }
    }

    class Program
    {
        static void Main()
        {
            PaperBook paperBook = new PaperBook("Война и мир", "Лев Толстой", 1225);
            EBook ebook = new EBook("Чистый код", "Роберт Мартин", 5.2);

            Console.WriteLine($"Бумажная книга: {paperBook.Title}, автор: {paperBook.Author}, страниц: {paperBook.Pages}");
            Console.WriteLine($"Электронная книга: {ebook.Title}, автор: {ebook.Author}, размер: {ebook.FileSize} МБ");
        }
    }
}