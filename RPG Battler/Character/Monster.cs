using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Defines monster enemies that are the ones fighting the heroes
namespace RPG_Battler.Character
{
    public class Monster : Creations
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage {get; set;}
        public Monster(string name)
        {
            Name = name;
            Health = 80;
        }
    }
}
