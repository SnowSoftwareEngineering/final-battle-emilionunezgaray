using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battler.Character.Upgrades
{
    // Spell class, it grows stronger over time - Encapsulation, DateTime
    public class Spell
    {
        public string Name { get; set; }
        public int BasePower { get; set; }
        public DateTime LearnedDate {get; private set;}
        public Spell(string name, int basePower)
        {
            Name = name;
            BasePower = basePower;
            LearnedDate = DateTime.Now;
        }

        // Calculate current power, based on time elapsed - DateTime
        public int CurrentPower()
        {
            int daysSinceLearned = (int)(DateTime.Now - LearnedDate).TotalDays;
            return BasePower + daysSinceLearned;
        }

        // Spell info
        public void Display()
        { 
            Console.WriteLine($"{Name} - Current Power: {CurrentPower()}");
        }
    }
}
