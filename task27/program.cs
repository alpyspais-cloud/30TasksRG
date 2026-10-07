using System;

namespace Task27
{
    class File
    {
        public string Name { get; set; }
        public double Size { get; set; }

        public File(string name, double size)
        {
            Name = name;
            Size = size;
        }

        public virtual void Open()
        {
            Console.WriteLine($"Открывается файл {Name}");
        }
    }

    class TextFile : File
    {
        public TextFile(string name, double size)
            : base(name, size)
        {
        }

        public override void Open()
        {
            Console.WriteLine(
                $"Текстовый файл {Name} открыт в текстовом редакторе.");
        }
    }

    class ImageFile : File
    {
        public ImageFile(string name, double size)
            : base(name, size)
        {
        }

        public override void Open()
        {
            Console.WriteLine(
                $"Изображение {Name} открыто в просмотрщике изображений.");
        }
    }

    class VideoFile : File
    {
        public VideoFile(string name, double size)
            : base(name, size)
        {
        }

        public override void Open()
        {
            Console.WriteLine(
                $"Видео {Name} открыто в видеоплеере.");
        }
    }

    class Program
    {
        static void Main()
        {
            File[] files =
            {
                new TextFile("notes.txt", 12),
                new ImageFile("photo.png", 2048),
                new VideoFile("clip.mp4", 50000)
            };

            foreach (File file in files)
            {
                file.Open();
            }
        }
    }
}