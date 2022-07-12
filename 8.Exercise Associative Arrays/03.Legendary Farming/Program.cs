using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Legendary_Farming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, int> validItemsQuantity = new Dictionary<string, int>();
            Dictionary<string, int> invalidItemsQuantity = new Dictionary<string, int>();

            while (true)
            {
                List<string> input = Console.ReadLine()
                    .Split()
                    .Select(x => x.ToLower())
                    .ToList();
                for (int i = 0; i < input.Count - 1; i += 2)
                {
                    int materialQty = int.Parse(input[i]);
                    string materialName = input[i + 1];
                    
                    if (materialName == "shards" || materialName == "fragments" || materialName == "motes")
                    {
                        if (!validItemsQuantity.ContainsKey(materialName))
                        {
                            validItemsQuantity.Add(materialName, 0);
                        }
                        validItemsQuantity[materialName] += materialQty;

                        foreach (var validItem in validItemsQuantity)
                        {
                            if (validItem.Value >= 250)
                            {
                                string winingItem = validItem.Key;
                                validItemsQuantity[validItem.Key] -= 250;

                                if (winingItem == "shards")
                                {
                                    Console.WriteLine("Shadowmourne obtained!");
                                    foreach (var item in validItemsQuantity)
                                    {                                                                                
                                            Console.WriteLine($"{item.Key}: {item.Value}");                                        
                                    }
                                    
                                    foreach (var invalidItem in invalidItemsQuantity)
                                    {
                                        Console.WriteLine($"{invalidItem.Key}: {invalidItem.Value}");
                                    }
                                    return;
                                }
                                else if (winingItem == "fragments")
                                {
                                    Console.WriteLine("Valanyr obtained!");
                                    foreach (var item in validItemsQuantity)
                                    {                                                                               
                                            Console.WriteLine($"{item.Key}: {item.Value}");                                        
                                    }

                                    foreach (var invalidItem in invalidItemsQuantity)
                                    {
                                        Console.WriteLine($"{invalidItem.Key}: {invalidItem.Value}");
                                    }
                                    return;
                                }
                                else if (winingItem == "motes")
                                {
                                    Console.WriteLine("Dragonwrath obtained!");
                                    foreach (var item in validItemsQuantity)
                                    {                                                                                
                                            Console.WriteLine($"{item.Key}: {item.Value}");                                        
                                    }

                                    foreach (var invalidItem in invalidItemsQuantity)
                                    {
                                        Console.WriteLine($"{invalidItem.Key}: {invalidItem.Value}");
                                    }
                                    return;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (!invalidItemsQuantity.ContainsKey(materialName))
                        {
                            invalidItemsQuantity.Add(materialName, 0);                            
                        }
                        invalidItemsQuantity[materialName] += materialQty;
                    }                    
                }
            }
        }
    }
}
