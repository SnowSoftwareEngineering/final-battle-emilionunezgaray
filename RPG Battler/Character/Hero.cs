using RPG_Battler.Character.Upgrades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            Level = 1;
            TotalHealth = 25;
            TotalPower = 5;
            TotalLuck = 3;
        }

        public void EquipItem(Equipment equipment)
        {
            Equipments.Add(equipment);
            TotalPower += equipment.PowerBoost;
            Console.WriteLine($"Equipped {equipment.Name}. Power increased by {equipment.PowerBoost}.");
        }

        public void LearnSkill(Skill skill)
        {
            Skills.Add(skill);
            Console.WriteLine($"Learned new skill: {skill.Name} (Power: {skill.Power}, Cooldown: {skill.Cooldown})");
        }

        public void LearnSpell(Spell spell)
        {
            Spells.Add(spell);
            Console.WriteLine($"Studied new spell: {spell.Name} (Power: {spell.Power}, Time: {spell.StudyTime})");
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
