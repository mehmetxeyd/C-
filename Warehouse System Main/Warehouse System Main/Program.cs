using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_System_Main
{
    internal class Program
    {
        static List<Product> products = new List<Product>();
        static void Main(string[] args)
        {
            LoadProducts();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Welcome to the Warehouse Management System!");
                Console.WriteLine("1: Register Products");
                Console.WriteLine("2: Check Availability");
                Console.WriteLine("3: Place Order");
                Console.WriteLine("4: Save Products");
                Console.WriteLine("5: Display All Products");
                Console.WriteLine("6: Exit");
                Console.WriteLine("Enter number: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        RegisterProducts();
                        break;
                    case "2":
                        CheckIfAvailable();
                        break;
                    case "3":
                        PlaceOrder();
                        break;
                    case "4":
                        SaveProducts();
                        break;
                    case "5":
                        DisplayAllProducts();
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Please enter the correct number");
                        break;

                }
            }
        }

        static void RegisterProducts()
        {
            Console.WriteLine("Please Enter Product name");
            string productName = Console.ReadLine();
            Console.WriteLine("Please Enter the Quantity");
            int productQuantity = int.Parse(Console.ReadLine());

            Product newProduct = new Product(productName, productQuantity);
            products.Add(newProduct);

            Console.WriteLine("Your Product has successfully been added.");
        }

        static void CheckIfAvailable()
        {
            {
                Console.WriteLine("Enter the product name to check availability:");
                string productName = Console.ReadLine();

                Product foundProduct = null;
                foreach (var product in products)
                {
                    if (product.itemName.Equals(productName, StringComparison.OrdinalIgnoreCase))
                    {
                        foundProduct = product;
                        break;
                    }
                }


                if (foundProduct != null)
                {
                    Console.WriteLine($"Product: {foundProduct.itemName}, Quantity: {foundProduct.Quantity}, State: {foundProduct.State}");
                }

                else
                {
                    Console.WriteLine("Product not found.");
                }


            }

        }

        static void PlaceOrder()
        {
            Console.WriteLine("Enter the product name to order:");
            string productName = Console.ReadLine();

            Console.WriteLine("Enter the quantity to order:");
            if (!int.TryParse(Console.ReadLine(), out int orderQuantity))
            {
                Console.WriteLine("Invalid quantity. Please enter a number.");
                return;
            }

            Product foundProduct = null;

            foreach (var product in products)
            {
                if (product.itemName == productName)
                {
                    foundProduct = product;
                    break;
                }
            }

            if (foundProduct == null)
            {
                Console.WriteLine("Product not found.");
                return;
            }

            if (orderQuantity <= foundProduct.Quantity)
            {
                foundProduct.DifferenceinQuantity(-orderQuantity);
                Console.WriteLine($"Order placed for {orderQuantity} of {foundProduct.itemName}. Updated quantity: {foundProduct.Quantity}");
            }
            else
            {
                Console.WriteLine("Not enough stock available for this order.");
            }
        }

        static void SaveProducts()
        {
            var lines = new List<string>();
            foreach (var product in products)
            {
                lines.Add($"{product.itemName},{product.Quantity},{product.State}");
            }

            File.WriteAllLines("products.txt", lines);
            Console.WriteLine("Products have been saved.");
        }

        static void LoadProducts()
        {
            if (File.Exists("products.txt"))
            {
                string[] lines = File.ReadAllLines("products.txt");
                foreach (var line in lines)
                {
                    var details = line.Split(',');
                    string name = details[0];
                    int quantity = int.Parse(details[1]);
                    string state = details[2];

                    Product newProduct = new Product(name, quantity)
                    {
                        State = state
                    };
                    products.Add(newProduct);
                }
            }
            else
            {
                Console.WriteLine("No previous product data found.");
            }
        }

        static void DisplayAllProducts()
        {
            Console.WriteLine("All products in the warehouse:");
            foreach (var product in products)
            {
                Console.WriteLine($"Product: {product.itemName}, Quantity: {product.Quantity}, State: {product.State}");
            }
        }

    }
}