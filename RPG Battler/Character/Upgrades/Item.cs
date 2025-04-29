using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battler.Character.Upgrades
{
    // Abstract base class for all items - Abstraction
    public abstract class Item
    {
        public string Name { get; set; }
        public Item(string name) 
        {
            Name = name; 
        }

        // Abstract Display method, overridden - Abstraction
        public abstract void Display();
    }
}
