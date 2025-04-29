using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Battler.Character;

namespace RPG_Battler.Gameplay
{
    // Combat class handles battles between Heroes and Monsters
    public class Combat
    {
        private Random random = new Random();

        // Async Battle method with randomized mechanics
        public async Task<bool> BattleAsync(Hero hero, Monster monster)
        {
            Console.WriteLine($"\nBattle Starts: {hero.Name} vs {monster.Name} ({monster.MonsterType})");
            await Task.Delay(1000);

            // Add randomness to each attack
            int heroAttack = hero.TotalPower + random.Next(0, hero.TotalLuck + 1);
            int monsterAttack = monster.TotalPower + random.Next(0, monster.TotalLuck + 1);

            Console.WriteLine($"{hero.Name} attacks with power: {heroAttack}");
            Console.WriteLine($"{monster.Name} attacks with power: {monsterAttack}");

            bool heroWins = heroAttack >= monsterAttack;

            Console.WriteLine(heroWins ? $"{hero.Name} wins the battle!" : $"{monster.Name} defeats {hero.Name}");
            return heroWins;
        }

        // LINQ + Lambda example: Get strongest monster from list
        public Monster FindStrongestMonster(List<Monster> monsters)
        {
            return monsters.OrderByDescending(m => m.TotalPower).FirstOrDefault();
        }

        // Extra method for finding a random monster
        public Monster GetRandomMonster(List<Monster> monsters)
        {
            return monsters[random.Next(monsters.Count)];
        }
    }
}
