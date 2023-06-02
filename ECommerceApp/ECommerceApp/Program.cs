using ECommerceApp;
using System;
using System.Collections.Generic;

class Program
{
    private static List<Product> products = new List<Product>();
    private static int nextProductId = 1;

    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Create a product");
            Console.WriteLine("2. Read a product's details");
            Console.WriteLine("3. Update a product's details");
            Console.WriteLine("4. Delete a product");
            Console.WriteLine("5. Exit");

            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    CreateProduct();
                    break;
                case "2":
                    ReadProduct();
                    break;
                case "3":
                    UpdateProduct();
                    break;
                case "4":
                    DeleteProduct();
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
            Console.WriteLine();
        }
    }

    static void CreateProduct()
    {
        Console.WriteLine("Enter the product name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the product price:");
        decimal price = decimal.Parse(Console.ReadLine());

        Product product = new Product
        {
            ProductId = nextProductId++,
            Name = name,
            Price = price
        };
        products.Add(product);

        Console.WriteLine("Product created successfully.");
    }

    static void ReadProduct()
    {
        Console.WriteLine("Enter the product ID:");
        int productId = int.Parse(Console.ReadLine());

        Product product = products.Find(p => p.ProductId == productId);
        if (product != null)
        {
            Console.WriteLine($"Product ID: {product.ProductId}");
            Console.WriteLine($"Product Name: {product.Name}");
            Console.WriteLine($"Product Price: {product.Price}");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    static void UpdateProduct()
    {
        Console.WriteLine("Enter the product ID:");
        int productId = int.Parse(Console.ReadLine());

        Product product = products.Find(p => p.ProductId == productId);
        if (product != null)
        {
            Console.WriteLine("Enter the new product name:");
            string newName = Console.ReadLine();

            Console.WriteLine("Enter the new product price:");
            decimal newPrice = decimal.Parse(Console.ReadLine());

            product.Name = newName;
            product.Price = newPrice;

            Console.WriteLine("Product updated successfully.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    static void DeleteProduct()
    {
        Console.WriteLine("Enter the product ID:");
        int productId = int.Parse(Console.ReadLine());

        Product product = products.Find(p => p.ProductId == productId);
        if (product != null)
        {
            products.Remove(product);
            Console.WriteLine("Product deleted successfully.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }
}