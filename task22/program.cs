using System;

namespace Task22
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual double GetFinalPrice()
        {
            return Price;
        }
    }

    class Electronics : Product
    {
        public double WarrantyPrice { get; set; }

        public Electronics(
            string name,
            double price,
            double warrantyPrice)
            : base(name, price)
        {
            WarrantyPrice = warrantyPrice;
        }

        public override double GetFinalPrice()
        {
            return Price + WarrantyPrice;
        }
    }

    class Clothing : Product
    {
        public double Discount { get; set; }

        public Clothing(
            string name,
            double price,
            double discount)
            : base(name, price)
        {
            Discount = discount;
        }

        public override double GetFinalPrice()
        {
            return Price - Price * Discount / 100;
        }
    }

    class Food : Product
    {
        public double Tax { get; set; }

        public Food(
            string name,
            double price,
            double tax)
            : base(name, price)
        {
            Tax = tax;
        }

        public override double GetFinalPrice()
        {
            return Price + Price * Tax / 100;
        }
    }

    class Program
    {
        static void Main()
        {
            Product[] products =
            {
                new Electronics("Телефон", 50000, 3000),
                new Clothing("Куртка", 12000, 10),
                new Food("Хлеб", 100, 5)
            };

            foreach (Product product in products)
            {
                Console.WriteLine($"{product.Name}: итоговая цена {product.GetFinalPrice():F2}");
            }
        }
    }
}