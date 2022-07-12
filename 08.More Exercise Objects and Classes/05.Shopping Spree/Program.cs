using System;
using System.Collections.Generic;

namespace _05.Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] peopleInfo = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            string[] productsInfo = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            List<Person> personList = new List<Person>();
            List<Product> productList = new List<Product>();

            for (int i = 0; i < peopleInfo.Length; i++)
            {
                string[] personInfo = peopleInfo[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                Person currPerson = new Person(personInfo[0], int.Parse(personInfo[1]));
                personList.Add(currPerson);
            }
            for (int i = 0; i < productsInfo.Length; i++)
            {
                string[] productInfo = productsInfo[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                Product currProduct = new Product(productInfo[0], int.Parse(productInfo[1]));
                productList.Add(currProduct);
            }

            string[] command = Console.ReadLine().Split();
            while (command[0] != "END")
            {
                string currPersonName = command[0];
                string currProductToBuyName = command[1];

                Person currPerson = personList.Find(person => person.Name == currPersonName);
                Product currProductToBuy = productList.Find(product => product.Name == currProductToBuyName);

                if (currPerson.Money >= currProductToBuy.Cost)
                {
                    currPerson.Money -= currProductToBuy.Cost;
                    currPerson.Products.Add(currProductToBuy);
                    Console.WriteLine($"{currPersonName} bought {currProductToBuyName}");
                }
                else
                {
                    Console.WriteLine($"{currPersonName} can't afford {currProductToBuyName}");
                }
                command = Console.ReadLine().Split();
            }
            foreach (var person in personList)
            {
                if (person.Products.Count > 0)
                {
                    Console.Write($"{person.Name} - ");
                    Console.Write(person);
                    Console.WriteLine();
                }
                else
                {
                    Console.Write($"{person.Name} - ");
                    Console.Write("Nothing bought");
                    Console.WriteLine();
                }
            }
        }
    }

    class Person
    {
        public Person(string name, int money)
        {
            Name = name;
            Money = money;
            Products = new List<Product>();
        }

        public string Name { get; set; }
        public int Money { get; set; }
        public List<Product> Products { get; set; }

        public override string ToString()
        {
            List<string> productNames = new List<string>();
            foreach (var product in this.Products)
            {
                productNames.Add(product.Name);
            }
            return String.Join(", ", productNames.ToArray());
        }
    }

    class Product
    {

        public Product(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name { get; set; }
        public int Cost { get; set; }

       
    }
}
