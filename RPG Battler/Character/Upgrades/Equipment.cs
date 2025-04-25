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
        public EquipmentSlot Slot { get; set; }    
        public StatBoostType StatBoostType { get; set; } 
        public int BoostValue { get; set; }

        public Equipment() 
        { 
        }

        public Equipment(string name, EquipmentSlot slot, StatBoostType statBoostType, int boostValue)
        {
            EquipmentName = name;
            Slot = slot;
            StatBoostType = statBoostType;
            BoostValue = boostValue;
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
