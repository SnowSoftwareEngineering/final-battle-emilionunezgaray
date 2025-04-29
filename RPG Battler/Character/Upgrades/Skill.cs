using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battler.Character.Upgrades
{
    // Skill class, specialized abilities for Heroes - Encapsulation
    public class Skill
    {
        // Encapsulation
        public string Name { get; set; }
        public int PowerBoost { get; set; }
        public int CooldownDays { get; set; } // Days until skill can be reused

        private DateTime lastUsed; // Encapsulation with private field
        public Skill(string name, int powerBoost, int cooldownDays)
        {
            Name = name;
            PowerBoost = powerBoost;
            CooldownDays = cooldownDays;
            lastUsed = DateTime.MinValue;
        }

        // Check if Skill is available based on cooldown - DateTime
        public bool IsAvailable()
        {
            return (DateTime.Now - lastUsed).TotalDays >= CooldownDays;
        }

        // Use the Skill, update lastUsed - DateTime
        public void UseSkill()
        {
            if (IsAvailable())
            {
                lastUsed = DateTime.Now;
                Console.WriteLine($"{Name} used! Power boost: {PowerBoost}");
            }
            else
            {
                Console.WriteLine($"{Name} is on cooldown. Please wait.");
            }
        }
    }
}
