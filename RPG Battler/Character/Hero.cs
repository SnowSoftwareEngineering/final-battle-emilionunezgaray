using RPG_Battler.Character.Upgrades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battler.Character
{
    public class Hero : Creations
    {
        // Properties for current battle stats
        public int Health { get; set; }
        public int Power { get; set; }
        public int Luck { get; set; }
        public int Mana { get; set; }

        // XP remaining to next level
        public int ExperienceRemaining { get; set; }

        // Class-specific stat progression
        public CombatClass CombatClass { get; set; }

        // Equipment, items, skills, spells lists
        public List<Item> Items { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Spell> Spells { get; set; }
        public List<Equipment> Equipments {get; set;}

        // Dictionary to track wear and tear per equipment piece
        public Dictionary<Equipment, double> EquipmentDurability {get; private set;} = new();

        // Date when the hero was last leveled
        public DateTime LastLevelUpdate {get; set;} = DateTime.Now; 
        public Hero()
        {
        }

        public void LevelUp()
        {
           Level++;
           ExperienceRemaining = 100 * Level;
           TotalHealth += 10;
           TotalPower += 5;
           TotalLuck += 2;
           Health = TotalHealth;
           Power = TotalPower;
           Luck = TotalLuck;
           Mana += 5;
        }

        public void CalculateTotals()
        {
            TotalHealth = Health;
            TotalPower = Power;
            TotalLuck = Luck;

            foreach (var equip in Equipments)
            {
                switch (equip.StatBoostType)
                {
                    case StatBoostType.Health:
                    TotalHealth += equip.BoostValue;
                    break;
                    case StatBoostType.Power:
                    TotalPower += equip.BoostValue;
                    break;
                    case StatBoostType.Luck:
                    TotalLuck += equip.BoostValue;
                    break;
                }
            }
        }

    }

}
