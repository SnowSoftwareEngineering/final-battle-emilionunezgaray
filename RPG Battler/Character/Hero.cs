using RPG_Battler.Character.Upgrades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

// Hello professor, I will include comments that explain what I added to recover some points.
// as well as the requirements that are completed
namespace RPG_Battler.Character
{
    public class Hero : Creations
    {
        private List<Skill> Skills = new List<Skill>();
        private List<Spell> Spells = new List<Spell>();
        private List<Equipment> Equipments = new List<Equipment>();

        public Hero(string name)
        {
            Name = name;
            Level = 2;
            TotalHealth = 25;
            TotalPower = 20;
            TotalLuck = 3;
        }

        // JSOM
        public void SaveHero(string filepath)
        {
            var options = new JsonSerializerOptions {WriteIndented = true};
            string json = JsonSerializer.Serialize(this, options);
            File.WriteAllText(filepath, json);
        }

        public static Hero LoadHero(string filepath)
        {
            string json = File.ReadAllText(filepath);
            return JsonSerializer.Deserialize<Hero>(json);
        }

        // Applying the attribute
        [Hero("This class defines the main controllable Hero character with level, stats, equipment, and skills")]
        public class Heros {}
        public void EquipItem(Equipment equipment)
        {
            Equipments.Add(equipment);
            TotalPower += equipment.PowerBoost;
            Console.WriteLine($"Equipped {equipment.Name}. Power increased by {equipment.PowerBoost}.");
        }

        public void LearnSkill(Skill skill)
        {
            Skills.Add(skill);
            Console.WriteLine($"Learned new skill: {skill.Name} (Power: {skill.PowerBoost}, Cooldown: {skill.CooldownDays})");
        }

        public void LearnSpell(Spell spell)
        {
            Spells.Add(spell);
            Console.WriteLine($"Studied new spell: {spell.Name} (Power: {spell.BasePower}, Time: {spell.LearnedDate})");
        }

        public override void DisplayStats()
        {
            Console.WriteLine($"\nHero: {Name}");
            Console.WriteLine($"Level: {Level}, Health: {TotalHealth}, Power: {TotalPower}, Luck: {TotalLuck}");
            Console.WriteLine("Skills: " + (Skills.Count == 0 ? "None" : string.Join(", ", Skills.ConvertAll(s => s.Name))));
            Console.WriteLine("Spells: " + (Spells.Count == 0 ? "None" : string.Join(", ", Spells.ConvertAll(s => s.Name))));
        }
    }
}
