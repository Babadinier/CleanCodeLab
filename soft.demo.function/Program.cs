using System;
using System.Collections.Generic;
using System.Linq;

namespace soft.demo.function
{
    class Program
    {
        public const string MILK = "MILK";
        static void Main(string[] args)
        {
            var basket = new Basket(Guid.NewGuid());

            var milk = new Product(MILK, 2m);

            AddProduct(basket, milk);
            AddProduct(basket, milk);

            System.Console.WriteLine($"Basket: Number of product: {basket.Products.Count }, total price: {basket.Price}");
        }

        public static void AddProduct(Basket basket, Product product)
        {
            var existingProduct = basket.Products.SingleOrDefault(x => x.Name == product.Name);
            if (existingProduct == null)
            {
                if (product.Name == MILK)
                {
                    product.Price = 0.5m * product.Price;
                }
                basket.Products.Add(product);
            }

            basket.Price = basket.Products.Sum(product => product.Price);
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }

    public class Basket
    {
        public Guid Id { get; set; }
        public List<Product> Products { get; set; }
        public decimal Price { get; set; }

        public Basket(Guid id)
        {
            Id = id;
            Products = new List<Product>();
            Price = 0.0m;
        }
    }
}
