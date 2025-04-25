using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Battler.Character.Upgrades;

namespace RPG_Battler.Gameplay
{
    public class LootBox
    {
        public static Item GetRandomItem()
        {
            return new Item("Health Potion", "Restores 20 HP") { ItemPower = 20 };
        }

        public static Equipment GetRandomEquipment()
        {
            return new Equipment("Iron Sword", EquipmentSlot.RightArm, StatBoostType.Power, 5);
        }
    }
}
