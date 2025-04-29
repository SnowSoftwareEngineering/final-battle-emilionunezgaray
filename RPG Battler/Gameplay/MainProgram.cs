using System.Text.Json;
using RPG_Battler.Character;
using RPG_Battler.Character.Upgrades;
using RPG_Battler.Gameplay;

namespace RPG_Battler
{
    class MainProgram
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to RPG Battler!\n");

            // Create Hero
            Console.Write("Enter your hero's name: ");
            string heroName = Console.ReadLine();
            Hero hero = new Hero(string.IsNullOrWhiteSpace(heroName) ? "DefaultHero" : heroName);
            hero.DisplayStats();

            // Create list of monsters
            List<Monster> monsters = new List<Monster>
            {
                new Monster("Big Foot", "Beast", 1, 20, 5, 3),
                new Monster("Evil Poseidon", "Warrior", 2, 30, 8, 2),
                new Monster("Haunted Dragon", "Legendary", 5, 50, 15, 5)
            };

            // Select random monster for the battle
            Random rand = new Random();
            Monster selectedMonster = monsters[rand.Next(monsters.Count)];

            Combat combat = new Combat();
            Console.WriteLine($"\nYour enemy is: {selectedMonster.Name} (Type: {selectedMonster.MonsterType})");

            // Simulate battle
            bool heroWins = await combat.BattleAsync(hero, selectedMonster);

            if (heroWins)
            {
                Console.WriteLine("\nVictory! You earned a reward!");

                LootBox lootBox = new LootBox();

                Console.WriteLine("Choose your reward:\n1 - Equipment\n2 - Skill\n3 - Spell");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Equipment eq = lootBox.Open();
                        hero.EquipItem(eq);
                        break;

                    case "2":
                        Skill sk = lootBox.OpenSkillBox();
                        hero.LearnSkill(sk);
                        Console.WriteLine($"New skill learned: {sk.Name}");
                        break;

                    case "3":
                        Spell sp = lootBox.OpenSpellBox();
                        hero.LearnSpell(sp);
                        Console.WriteLine($"New spell learned: {sp.Name}");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. No reward granted.");
                        break;
                }

                // Show updated stats
                hero.DisplayStats();
            }
            else
            {
                Console.WriteLine("\nYou were defeated... Game Over.");
            }

            Console.WriteLine("\nThanks for playing!");
        }
    }
}
