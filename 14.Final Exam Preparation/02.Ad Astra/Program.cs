using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            string input = Console.ReadLine();

            string pattern = @"(?<sep>#|\|)(?<name>[A-Za-z\s]+)(\k<sep>)(?<date>\d{2}\/\d{2}\/\d{2})(\k<sep>)(?<calories>\d+)(\k<sep>)";

            MatchCollection productMatches = Regex.Matches(input, pattern);

            foreach (Match product in productMatches)
            {
                string name = product.Groups["name"].Value;
                string expDate = product.Groups["date"].Value;
                int calories = int.Parse(product.Groups["calories"].Value);

                var newProduct = new Product(name, expDate, calories);
                products.Add(newProduct);
            }

            int totalCalories = products
                .Select(product => product.Calories)
                .Sum();
            int daysWithFood = totalCalories / 2000;

            Console.WriteLine($"You have food to last you for: {daysWithFood} days!");
            foreach (var product in products)
            {
                Console.WriteLine($"Item: {product.Name}, Best before: {product.ExpDate}, Nutrition: {product.Calories}");
            }
        }
    }

    class Product
    {
        public Product(string name, string expDate, int calories)
        {
            Name = name;
            ExpDate = expDate;
            Calories = calories;
        }

        public string Name { get; set; }
        public string ExpDate { get; set; }
        public int Calories { get; set; }
    }
}
