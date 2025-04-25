using RPG_Battler.Character;
using RPG_Battler.Character.Upgrades;

namespace RPG_Battler.Gameplay
{
    class MainProgram
    {
        static void Main()
        {
            var hero = new Hero
            {
                Name = "Arden",
                Level = 1,
                Health = 100,
                Power = 15,
                Luck = 5,
                Mana = 20,
                ExperienceRemaining = 100,
                CombatClass = CombatClass.Warrior,
                Items = new List<Item>(),
                Skills = new List<Skill>(),
                Spells = new List<Spell> { new Spell("Fireball", 5, 20) },
                Equipments = new List<Equipment>()
            };

            hero.CalculateTotals();

            var monster = new Monster
            {
                Name = "Goblin",
                Level = 1,
                TotalHealth = 50,
                TotalPower = 10,
                TotalLuck = 2
            };

            Combat.StartBattle(hero, monster);

            if (hero.Health > 0)
            {
                hero.LevelUp();
                var loot = LootBox.GetRandomEquipment();
                hero.Equipments.Add(loot);
                hero.CalculateTotals();

                Console.WriteLine($"\n{hero.Name} leveled up and received: {loot.EquipmentName} (+{loot.BoostValue} {loot.StatBoostType})");
            }
        }
    }
}
