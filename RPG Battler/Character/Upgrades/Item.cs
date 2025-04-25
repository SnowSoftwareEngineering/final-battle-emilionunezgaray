using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battler.Character.Upgrades
{
    public class Item
    {
        public string ItemName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ItemPower { get; set; } 
        public Item() 
        { 
        }

        public Item(string name, string description)
        {
            ItemName = name;
            Description = description;
        }
    }
}
