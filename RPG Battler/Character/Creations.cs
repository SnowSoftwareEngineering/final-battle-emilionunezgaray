using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battler.Character
{
    // Abstract base class - Abstraction, Inheritance
    public abstract class Creations
    {
        // Common stats - Emcapsulation
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; }
        public int TotalHealth { get; set; }
        public int TotalPower { get; set; }
        public int TotalLuck { get; set; }

        // Abstract method - forces subclasses to implement their own DisplayStats
        public abstract void DisplayStats();
    }
}