using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battler.Character.Upgrades
{
    public class Skill
    {
        public string SkillName { get; set; }
        public int BaseDamage { get; set; }
        public int MaxCooldown { get; private set; }
        public int CurrentCooldown { get; private set; }

        public Skill(string name, int baseDamage, int cooldown)
        {
            SkillName = name;
            BaseDamage = baseDamage;
            MaxCooldown = cooldown;
            CurrentCooldown = 0; // Ready to use at the start
        }

        public void UseSkill(Hero hero)
        {
            if (CurrentCooldown == 0)
            {
                Console.WriteLine($"{hero.Name} uses {SkillName}!");
                CurrentCooldown = MaxCooldown;
            }
            else 
            {
                Console.WriteLine($"{SkillName} is on cooldown for {CurrentCooldown} more turns.");
            }
        }

        public void CooldownTick()
        {
            if (CurrentCooldown > 0)
            {
                CurrentCooldown--;
            }
        }
    }
}
