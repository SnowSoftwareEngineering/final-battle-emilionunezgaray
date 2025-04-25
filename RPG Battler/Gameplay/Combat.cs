using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Battler.Character;

namespace RPG_Battler.Gameplay
{
    public class Combat
    {
        public static void StartBattle(Hero hero, Monster monster)
        {
            Console.WriteLine($"A wild {monster.Name} appears!");

            while (hero.Health > 0 && monster.TotalHealth > 0)
            {
                Console.WriteLine($"\n{hero.Name}: HP {hero.Health}/{hero.TotalHealth}, Mana: {hero.Mana}");
                Console.WriteLine($"{monster.Name}: HP {monster.TotalHealth}");

                Console.Write("Choose Action - [A]ttack [S]pell [Q]uit: ");
                var input = Console.ReadKey().Key;
                Console.WriteLine();

                switch (input)
                {
                    case ConsoleKey.A:
                    int damage = hero.Power;
                    monster.TotalHealth -= damage;
                    Console.WriteLine($"{hero.Name} attacks for {damage} damage!");
                    break;

                    case ConsoleKey.S:
                    if (hero.Spells.Any())
                    hero.Spells[0].CastSpell(hero);
                    break;

                    case ConsoleKey.Q:
                    return;
                }

                if (monster.TotalHealth > 0)
                {
                    int enemyDamage = 5;
                    hero.Health -= enemyDamage;
                    Console.WriteLine($"{monster.Name} hits back for {enemyDamage} damage!");
                }
            }
            Console.WriteLine(hero.Health > 0 ? "\nYou won!" : "\nYou were defeated...");
        }
    }
}
