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
        public int Health { get; set; }
        public int Power { get; set; }
        public int Luck { get; set; }
        public int Mana { get; set; }
        public int ExperienceRemaining { get; set; }
        public CombatClass CombatClass { get; set; }
        public List<Item> Items { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Spell> Spells { get; set; }
        public List<Equipment> Equipment { get; set; }

        public Hero()
        {
            Name = "unknown";    
            Level = 0;
            Health = 1;
            Power = 1;
            Luck = 1;
            Mana = 0;
            ExperienceRemaining = 0;
            CombatClass = CombatClass.None;
            Items = new List<Item>();
            Skills = new List<Skill>();
            Spells = new List<Spell>();
            Equipment = new List<Equipment>();   
        }

        public void LevelUp()
        {
            Random rng = new Random();
            Level++;

            switch(CombatClass)
            {
                case CombatClass.Wizard:
                Health += rng.Next(1, 16); // 1-15
                Power += rng.Next(3, 6); // 3-5
                Luck += rng.Next(1, 4);  // 1-3
                break;

                case CombatClass.Warrior:
                Health += rng.Next(10, 21); // 10-20
                Power += rng.Next(1, 4); // 1-3
                Luck += rng.Next(1,4); // 1-3
                break; 

                case CombatClass.Rogue:
                Health += rng.Next(1, 16); // 1-15
                Power += rng.Next(1, 4);   // 1-3 
                Luck += rng.Next(3, 6);    // 3-5
                break;

                default: throw new InvalidOperationException("CombatClass must be set before leveling up.");
            }
            CalculateTotals();
        }

        public void CalculateTotals()
        {
        }

        public void DisplayStats(bool showTotal = true)
        {
            // here will be the code for later
        }
    }
}
