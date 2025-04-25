using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battler.Character.Upgrades

{
    public class Equipment
    {
        public string EquipmentName { get; set; } = string.Empty;
        public EquipmentSlot Slot { get; set; } 
        public StatBoostType StatBoostType { get; set; } 
        public int BoostValue { get; set; } 
        public double Durability {get; set;} = 100; 

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
