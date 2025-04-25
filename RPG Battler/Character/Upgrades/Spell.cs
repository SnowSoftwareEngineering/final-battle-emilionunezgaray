using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Represents magical abilities that cost mana to cast
namespace RPG_Battler.Character.Upgrades
{
    public class Spell
    {
        public string SpellName { get; set; }
        public int ManaCost { get; set; }
        public int BaseDamage { get; set; }
        public DateTime StudyStartDate {get; set;} = DateTime.Now;


        public Spell(string name, int manaCost, int baseDamage)
        {
            SpellName = name;
            ManaCost = manaCost;
            BaseDamage = baseDamage;
        }

        public int CalculateSpellDamage(int heroPower)
        {
            int daysStudied = (DateTime.Now - StudyStartDate).Days;
            return BaseDamage + (heroPower / 2) + daysStudied;
        }

        public void CastSpell(Hero hero)
        { 
            if(hero.Mana >= ManaCost)
            {
                hero.Mana -= ManaCost;
            }
        }
    }
}
