using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battler.Character.Upgrades
{
    public class Spell
    {
        public string SpellName { get; set; }
        public int ManaCost { get; set; }
        public int BaseDamage { get; set; }

        public Spell(string name, int manaCost, int baseDamage)
        {
            SpellName = name;
            ManaCost = manaCost;
            BaseDamage = baseDamage;
        }

        public int CalculateSpellDamage(int heroPower)
        {
            return BaseDamage + (heroPower / 2);
        }

        public void CastSpell(Hero hero)
        { 
            if (hero.Mana >= ManaCost)
            {
                int damage = CalculateSpellDamage(hero.Power);
                Console.WriteLine($"{hero.Name} casts {SpellName} for {damage} damage!");
                hero.Mana -= ManaCost;
            }
            else
            {
                Console.WriteLine($"{hero.Name} does not have enough mana to cast {SpellName}.");
            }
        }
    }
}
