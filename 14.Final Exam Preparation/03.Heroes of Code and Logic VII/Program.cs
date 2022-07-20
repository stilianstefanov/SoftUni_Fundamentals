using System;
using System.Collections.Generic;

namespace _03.Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Hero> heroList = new List<Hero>();
            const int MAX_HP = 100;
            const int MAX_MP = 200;

            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string newName = tokens[0];
                int newHP = int.Parse(tokens[1]);
                int newMP = int.Parse(tokens[2]);

                if (newHP > MAX_HP)
                {
                    newHP = MAX_HP;
                }
                if (newMP > MAX_MP)
                {
                    newMP = MAX_MP;
                }

                var newHero = new Hero(newName, newHP, newMP);
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
                        Recharge(heroList, command, MAX_MP);
                        break;
                    case "Heal":
                        Heal(heroList, command, MAX_HP);
                        break;
                }
                command = Console.ReadLine().Split(" - ");
            }
            foreach (var hero in heroList)
            {
                Console.WriteLine(hero.Name);
                Console.WriteLine($"  HP: {hero.HP}");
                Console.WriteLine($"  MP: {hero.MP}");
            }
        }

        private static void Heal(List<Hero> heroList, string[] command, int mAX_HP)
        {
            string currHeroName = command[1];
            int ammount = int.Parse(command[2]);
            int ammountRecovered = ammount;

            var currHero = heroList.Find(hero => hero.Name == currHeroName);
            if (currHero.HP + ammount > mAX_HP)
            {
                ammountRecovered = mAX_HP - currHero.HP;
                currHero.HP = mAX_HP;
            }
            else
            {
                currHero.HP += ammount;
            }
            Console.WriteLine($"{currHeroName} healed for {ammountRecovered} HP!");
        }

        private static void Recharge(List<Hero> heroList, string[] command, int maxMP)
        {
            string currHeroName = command[1];
            int ammount = int.Parse(command[2]);
            int ammountRecovered = ammount;
            
            var currHero = heroList.Find(hero => hero.Name == currHeroName);
            if (currHero.MP + ammount > maxMP)
            {
                ammountRecovered = maxMP - currHero.MP;
                currHero.MP = maxMP;
            }
            else
            {
                currHero.MP += ammount;
            }            
            Console.WriteLine($"{currHeroName} recharged for {ammountRecovered} MP!");
        }

        private static void TakeDamage(List<Hero> heroList, string[] command)
        {
            string currHeroName = command[1];
            int damage = int.Parse(command[2]);
            string attacker = command[3];

            var currHero = heroList.Find(hero => hero.Name == currHeroName);

            if (currHero.HP - damage > 0)
            {
                currHero.HP -= damage;
                Console.WriteLine($"{currHeroName} was hit for {damage} HP by {attacker} and now has {currHero.HP} HP left!");
            }
            else
            {
                heroList.Remove(currHero);
                Console.WriteLine($"{currHeroName} has been killed by {attacker}!");
            }
        }

        private static void CastSpell(List<Hero> heroList, string[] command)
        {
            string currHeroName = command[1];
            int requiredMP = int.Parse(command[2]);
            string spellName = command[3];

            var currHero = heroList.Find(hero => hero.Name == currHeroName);

            if (currHero.MP - requiredMP >= 0)
            {
                currHero.MP -= requiredMP;
                Console.WriteLine($"{currHeroName} has successfully cast {spellName} and now has {currHero.MP} MP!");
            }
            else
            {
                Console.WriteLine($"{currHeroName} does not have enough MP to cast {spellName}!");
            }
        }
    }

    class Hero
    {
        public Hero(string name, int hP, int mP)
        {
            Name = name;
            HP = hP;
            MP = mP;
        }

        public string Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }

    }
}
