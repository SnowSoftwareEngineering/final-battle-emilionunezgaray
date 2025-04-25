using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battler.Character.Upgrades
// This class defines equipment that can be used by heroes. Equipment can boost stats and degrade over time.
{
    public class Equipment
    {
        public string EquipmentName { get; set; } = string.Empty;
        public EquipmentSlot Slot { get; set; } // this is where the equipment is worn
        public StatBoostType StatBoostType { get; set; } // this is what stat this item boosts
        public int BoostValue { get; set; } // this is the amount the stat is boosted
        public double Durability {get; set;} = 100; // this is the Durability of the equipment

        public Equipment() 
        { 
        }

        public Equipment(string name, EquipmentSlot slot, StatBoostType statBoostType, int boostValue)
        {
            EquipmentName = name;
            Slot = slot;
            StatBoostType = statBoostType;
            BoostValue = boostValue;
            Durability = 100;
        }
    }
    public enum EquipmentSlot
    {
        Head,
        Chest,
        LeftArm,
        RightArm,
        Legs,
        Boots,
        Cape
    }

    public enum StatBoostType
    {
        Health,
        Power,
        Luck
    }
}
