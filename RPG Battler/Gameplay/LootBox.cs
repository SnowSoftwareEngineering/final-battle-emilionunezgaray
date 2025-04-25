using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Battler.Character.Upgrades;

// Generates random rewards for the hero
namespace RPG_Battler.Gameplay
{
    public class LootBox
    {
       private static Random rng = new Random();

       public static Equipment GenerateRandomEquipment()
       {
            string name = "Gem Stones";
            var slot = EquipmentSlot.RightArm;
            var stat = StatBoostType.Power;
            int value = rng.Next(5, 15);

            return new Equipment(name, slot, stat, value);
       }
    }
}
