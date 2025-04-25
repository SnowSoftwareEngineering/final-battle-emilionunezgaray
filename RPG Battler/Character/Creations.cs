using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Base class shared by all characters (hero or monster)
namespace RPG_Battler.Character
{
    public  class Creations
    {
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; }
        public int TotalHealth { get; set; }
        public int TotalPower { get; set; }
        public int TotalLuck { get; set; }
    }

    public enum CombatClass
    {
        None,
        Warrior,
        Wizard,
        Rogue
    }
}
