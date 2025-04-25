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
        public List<Equipment> Equipments {get; set;}

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
            Equipments = new List<Equipment>();  
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
