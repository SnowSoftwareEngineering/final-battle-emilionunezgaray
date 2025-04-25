using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Represents a combat skill a hero can use with cooldown
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
            if(CurrentCooldown == 0)
            {
                // You could integrate damage logic here
                CurrentCooldown = MaxCooldown;
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
