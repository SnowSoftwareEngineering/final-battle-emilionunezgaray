using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Battler.Character;

// Battle logic between a hero and a monster
namespace RPG_Battler.Gameplay
{
    public class Combat
    {
       private static Random rng = new Random();

        public static void Battle(Hero hero, Monster monster)
        {
            Console.WriteLine($" Battle Start: {hero.Name} vs {monster.Name}");
            Console.WriteLine();

            while (hero.Health > 0 && monster.Health > 0)
            {
                
                int heroDamage = rng.Next(5, 15);
                monster.Health -= heroDamage;
                Console.WriteLine($"{hero.Name} attacks {monster.Name} for {heroDamage} damage! (Monster HP: {Math.Max(monster.Health, 0)})");

                
                if (monster.Health <= 0)
                {
                    Console.WriteLine($"\n {hero.Name} wins!");
                    break;
                }
                
                bool monsterCrit = rng.NextDouble() < 0.25; 
                int monsterDamage = rng.Next(4, 12);
                if (monsterCrit)
                {
                    monsterDamage *= 2;
                    Console.WriteLine(" Critical hit by the Monster!");
                }
                hero.Health -= monsterDamage;
                Console.WriteLine($"{monster.Name} attacks {hero.Name} for {monsterDamage} damage! (Hero HP: {Math.Max(hero.Health, 0)})");

                if (hero.Health <= 0)
                {
                    Console.WriteLine($"\n {monster.Name} wins!");
                    break;
                }

                if (rng.NextDouble() < 0.10) 
                {
                    int healAmount = rng.Next(5, 10);
                    monster.Health += healAmount;
                    Console.WriteLine($"{monster.Name} heals for {healAmount} HP! (Monster HP: {monster.Health})");
                }

                Console.WriteLine(); 
            }
        }
    }
}
