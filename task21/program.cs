namespace Task21
{
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Triangle : Shape
    {
        public double BaseLength { get; set; }
        public double Height { get; set; }

        public Triangle(double baseLength, double height)
        {
            BaseLength = baseLength;
            Height = height;
        }

        public override double GetArea()
        {
            return BaseLength * Height / 2;
        }
    }

    class Square : Shape
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public override double GetArea()
        {
            return Side * Side;
        }
    }

    class Program
    {
        static void Main()
        {
            Shape[] shapes =
            {
                new Circle(2),
                new Rectangle(4, 5),
                new Triangle(3, 6),
                new Square(4)
            };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape.GetType().Name}: площадь {shape.GetArea():F2}");
            }
        }
    }
}