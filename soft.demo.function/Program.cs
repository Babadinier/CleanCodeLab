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

            AddProductAndUpdateBasket(basket, milk);
            AddProductAndUpdateBasket(basket, milk);

            var totalPrice = CalculateBasketTotal(basket, null);

            System.Console.WriteLine($"Basket: Number of product: {basket.Products.Count }, total price: {totalPrice}");
        }

        public static void AddProductAndUpdateBasket(Basket basket, Product product)
        {
            Product existingProduct = SearchProduct(basket, product);
            if (existingProduct == null)
            {
                if (product.Name == MILK)
                    product.Price = product.Price * 0.5m;
                basket.Products.Add(product);
            }

            basket.Price = basket.Products.Sum(product => product.Price);
        }

        public static Product SearchProduct(Basket basket, Product product)
        {
            return basket.Products.SingleOrDefault(x => x.Name == product.Name);
        }

        public static decimal CalculateBasketTotal(Basket basket, bool? hasPromo = null)
        {
            if (!Convert.ToBoolean(hasPromo))
                return basket.Price;
            else
                return basket.Price * 0.90m;
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
