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
        public int Damage {get; set;}
        public Monster(string name, int level, int health, int power, int luck, int damage)
        {
            Name = name;
            Level = level;
            TotalHealth = health;
            TotalPower = power;
            TotalLuck = luck;
            Damage = damage;
        }
    }
}
