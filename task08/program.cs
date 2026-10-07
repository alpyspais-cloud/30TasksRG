namespace Task08
{
    class Computer
    {
        public string Processor { get; set; }
        public int RAM { get; set; }

        public Computer(string processor, int ram)
        {
            Processor = processor;
            RAM = ram;
        }
    }

    class Laptop : Computer
    {
        public double ScreenSize { get; set; }

        public Laptop(
            string processor,
            int ram,
            double screenSize)
            : base(processor, ram)
        {
            ScreenSize = screenSize;
        }
    }

    class Desktop : Computer
    {
        public bool HasRGB { get; set; }

        public Desktop(
            string processor,
            int ram,
            bool hasRGB)
            : base(processor, ram)
        {
            HasRGB = hasRGB;
        }
    }

    class Program
    {
        static void Main()
        {
            Laptop laptop = new Laptop("Intel Core i7", 16, 15.6);
            Desktop desktop = new Desktop("AMD Ryzen 7", 32, true);

            Console.WriteLine($"Ноутбук: {laptop.Processor}, RAM: {laptop.RAM} ГБ, экран: {laptop.ScreenSize}\"");
            Console.WriteLine($"Компьютер: {desktop.Processor}, RAM: {desktop.RAM} ГБ, RGB: {(desktop.HasRGB ? "есть" : "нет")}");
        }
    }
}