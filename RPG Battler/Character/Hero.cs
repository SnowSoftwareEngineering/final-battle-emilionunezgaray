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
        public string Name {get; set;}
        public int Health { get; set; }
        public int Power { get; set; }
        public int Luck { get; set; }
        public int Mana { get; set; }

        public int ExperienceRemaining { get; set; }

        public CombatClass CombatClass { get; set; }

        public List<Item> Items { get; set; } = new();
        public List<Skill> Skills { get; set; } = new();
        public List<Spell> Spells { get; set; } = new();
        public List<Equipment> Equipment {get; set;} = new();

        
        public Dictionary<Equipment, double> EquipmentDurability {get; private set;} = new();

      
        public DateTime LastLevelUpdate {get; set;} = DateTime.Now; 
        public Hero(string name)
        {
            Name = name;
            Health = 100;
        }

        public void CalculateTotals()
        {
            TotalHealth = Health;
            TotalPower = Power;
            TotalLuck = Luck;

            foreach (var gear in Equipment.ToList())
            {
                if(gear.StatBoostType == StatBoostType.Health)
                TotalHealth += gear.BoostValue;

                else if(gear.StatBoostType == StatBoostType.Power)
                TotalPower += gear.BoostValue;

                else if(gear.StatBoostType == StatBoostType.Luck)
                TotalLuck += gear.BoostValue;
            }
        }

       
        public void LevelUp()
        {
            Level++;
            ExperienceRemaining = 100 + Level * 10; 
            LastLevelUpdate = DateTime.Now;

            switch (CombatClass)
            {
                case CombatClass.Warrior:
                    Health += 10;
                    Power += 5;
                    break;

                case CombatClass.Wizard:
                    Mana += 10;
                    Power += 3;
                    break;

                case CombatClass.Rogue:
                    Luck += 7;
                    Power += 3;
                    break;
            }

            CalculateTotals(); 
        }

        public void UpdateEquipmentDurability()
        {
            foreach(var equip in Equipment.ToList())
            {
                if(!EquipmentDurability.ContainsKey(equip))
                {
                    EquipmentDurability[equip] = 1.0;
                }

                EquipmentDurability[equip] = Math.Max(0, EquipmentDurability[equip] - 0.01);

                if (EquipmentDurability[equip] <= 0)
                {
                    Equipment.Remove(equip);
                    EquipmentDurability.Remove(equip);
                }
            }
        }

        public void GainExperience(int xp)
        {
            ExperienceRemaining -= xp;

            while (ExperienceRemaining <= 0)
            {
                LevelUp(); 
            }
        }
    }

}
