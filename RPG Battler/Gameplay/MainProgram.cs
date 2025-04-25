using System.Text.Json;
using RPG_Battler.Character;
using RPG_Battler.Character.Upgrades;

namespace RPG_Battler.Gameplay
{
    class MainProgram
    {
        static void Main()
        {
            Hero hero = new Hero("Batman");
            hero.LevelUp();

            Monster monster = new Monster("Riddle");
            Combat.Battle(hero, monster);

            Equipment loot = LootBox.GenerateRandomEquipment();
            Console.WriteLine($"Found Loot: {loot.EquipmentName} boosting {loot.StatBoostType} by {loot.BoostValue}");

            // Add loot to hero
            hero.Equipment.Add(loot);

            string savePath = "heroSave.json";
            string json = JsonSerializer.Serialize(hero, new JsonSerializerOptions {WriteIndented = true});
            File.WriteAllText(savePath, json);
            Console.WriteLine("Hero saved to JSON.");

            string loadedJson = File.ReadAllText(savePath);
            Hero loadedHero = JsonSerializer.Deserialize<Hero>(loadedJson);

            if(loadedHero != null)
            {
                Console.WriteLine($"Loaded hero: {loadedHero.Name}, Level {loadedHero.Level}");
            }
            else 
            {
                Console.WriteLine("Failed to load hero");
            }
        }
    }
}
