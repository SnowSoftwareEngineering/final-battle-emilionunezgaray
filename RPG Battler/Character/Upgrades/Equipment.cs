using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battler.Character.Upgrades
{
    // Enum to define what stat an equipment item boosts - Enum
    public enum StatBoostType
    {
        Health,
        Power,
        Luck
    }

    // Equipment class, inheritance of Item - Inheritance
    public class Equipment : Item
    {
        // Boost Type and value - Encapsulation
        public int PowerBoost {get; set;}

        public Equipment(string name, int powerBoost) : base(name)
        {
            PowerBoost = powerBoost;
        }

        // specific equipment display - method overiding - Polymorphism
        public override void Display()
        {
            Console.WriteLine($"{Name} (Power +{PowerBoost})");
        }
    }   
}

