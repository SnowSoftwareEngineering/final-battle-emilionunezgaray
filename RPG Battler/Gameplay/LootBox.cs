using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Battler.Character.Upgrades;

namespace RPG_Battler.Gameplay
{
    // LootBox grants random equipment, items, skills, or spells
    public class LootBox
    {
        private Random random = new Random();

        // Dictionary of possible equipment rewards
        private Dictionary<string, int> EquipmentRewards = new Dictionary<string, int>()
        {
            { "Golden Sword", 5 },
            { "Indestructible Armor", 8 },
            { "Super Speed Boots", 3 }
        };

        // Open loot box and get random Equipment
        public Equipment Open()
        {
            var reward = EquipmentRewards.ElementAt(random.Next(EquipmentRewards.Count));
            Console.WriteLine($"LootBox Reward: {reward.Key} (+{reward.Value} Power)");
            return new Equipment(reward.Key, reward.Value);
        }

        // Open Skill Box
        public Skill OpenSkillBox()
        {
            var skills = new List<Skill>
            {
                new Skill("Fireball", 10, 2),
                new Skill("Ice Shield", 8, 3),
                new Skill("Thunder Strike", 6, 1)
            };

            var chosenSkill = skills[random.Next(skills.Count)];
            Console.WriteLine($"You received skill: {chosenSkill.Name} (Power: {chosenSkill.PowerBoost})");
            return chosenSkill;
        }

        // Open Spell Box
        public Spell OpenSpellBox()
        {
            var spells = new List<Spell>
            {
                new Spell("Meteor Blast", 12),
                new Spell("Frost Nova", 9),
                new Spell("Arcane Pulse", 7)
            };

            var chosenSpell = spells[random.Next(spells.Count)];
            Console.WriteLine($"You received spell: {chosenSpell.Name} (Base Power: {chosenSpell.BasePower})");
            return chosenSpell;
        }
    }
}
