using System;
using System.Collections.Generic;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Hero> heroList = new List<Hero>();

            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                var newHero = new Hero(tokens[0], int.Parse(tokens[1]), int.Parse(tokens[2]));
                heroList.Add(newHero);
            }

            string[] command = Console.ReadLine().Split(" - ");
            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "CastSpell":
                        CastSpell(heroList, command);
                        break;
                    case "TakeDamage":
                        TakeDamage(heroList, command);
                        break;
                    case "Recharge":
                        Recharge(heroList, command);
                        break;
                    case "Heal":
                        Heal(heroList, command);
                        break;
                }
                command = Console.ReadLine().Split(" - ");
            }

            foreach (var hero in heroList)
            {
                Console.WriteLine($"{hero.Name}");
                Console.WriteLine($"   HP: {hero.Hitpoints}");
                Console.WriteLine($"   MP: {hero.ManaPoints}");
            }
        }

        private static void Heal(List<Hero> heroList, string[] command)
        {
            string currHeroName = command[1];
            int hitPointsToIncrease = int.Parse(command[2]);

            var currHero = heroList.Find(hero => hero.Name == currHeroName);
            int originalHitPoints = currHero.Hitpoints;

            currHero.Hitpoints += hitPointsToIncrease;
            if (currHero.Hitpoints > 100)
            {
                currHero.Hitpoints = 100;
            }

            Console.WriteLine($"{currHeroName} healed for {currHero.Hitpoints - originalHitPoints} HP!");
        }

        private static void Recharge(List<Hero> heroList, string[] command)
        {
            string currHeroName = command[1];
            int manaToIncrease = int.Parse(command[2]);

            var currHero = heroList.Find(hero => hero.Name == currHeroName);
            int originalMana = currHero.ManaPoints;

            currHero.ManaPoints += manaToIncrease;
            if (currHero.ManaPoints > 200)
            {
                currHero.ManaPoints = 200;
            }

            Console.WriteLine($"{currHeroName} recharged for {currHero.ManaPoints - originalMana} MP!");
        }

        private static void TakeDamage(List<Hero> heroList, string[] command)
        {
            string currHeroName = command[1];
            int HPRequired = int.Parse(command[2]);
            string atackerName = command[3];

            var currHero = heroList.Find(hero => hero.Name == currHeroName);
            if (currHero.Hitpoints - HPRequired <= 0)
            {
                heroList.Remove(currHero);
                Console.WriteLine($"{currHeroName} has been killed by {atackerName}!");
                return;
            }

            currHero.Hitpoints -= HPRequired;
            Console.WriteLine($"{currHeroName} was hit for {HPRequired} HP by {atackerName} and now has {currHero.Hitpoints} HP left!");
        }

        private static void CastSpell(List<Hero> heroList, string[] command)
        {
            string currHeroName = command[1];
            int manaRequired = int.Parse(command[2]);
            string spellName = command[3];

            var currHero = heroList.Find(hero => hero.Name == currHeroName);
            if (currHero.ManaPoints - manaRequired < 0)
            {
                Console.WriteLine($"{currHeroName} does not have enough MP to cast {spellName}!");
                return;
            }

            currHero.ManaPoints -= manaRequired;
            Console.WriteLine($"{currHeroName} has successfully cast {spellName} and now has {currHero.ManaPoints} MP!");
        }
    }

    class Hero
    {
        public Hero(string name, int hitpoints, int manaPoints)
        {
            Name = name;
            Hitpoints = hitpoints;
            ManaPoints = manaPoints;
        }

        public string Name { get; set; }
        public int Hitpoints { get; set; }
        public int ManaPoints { get; set; }
    }
}
