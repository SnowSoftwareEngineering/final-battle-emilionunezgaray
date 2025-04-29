using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battler.Character
{
    // Monster inherits from Creations - Inheritance
    public class Monster : Creations
    {
        // Monster specific properties - Encapsulation
        public string MonsterType { get; set; }
        public Monster(string name, string monsterType, int level, int totalHealth, int totalPower, int totalLuck)
        {
            Name = name;
            MonsterType = monsterType;
            Level = level;
            TotalHealth = totalHealth;
            TotalPower = totalPower;
            TotalLuck = totalLuck;
        }

        // Override DisplayStats method - Polymorphism
        public override void DisplayStats()
        {
            Console.WriteLine($"Monster: {Name} (Type: {MonsterType})");
            Console.WriteLine($"Level: {Level}, Health: {TotalHealth}, Power: {TotalPower}, Luck: {TotalLuck}");
        }
    }
}
