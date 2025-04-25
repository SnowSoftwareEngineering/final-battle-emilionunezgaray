using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Battler.Character;

// Battle logic between a hero and a monster
namespace RPG_Battler.Gameplay
{
    public class Combat
    {
       public static string Fight(Hero hero, Monster monster)
       {
        while (hero.Health > 0 && monster.TotalHealth > 0)
        {
            monster.TotalHealth -= hero.Power;
            if(monster.TotalHealth <= 0)
            return $"{hero.Name} wins!";

            hero.Health -= monster.Damage;
            if(hero.Health <= 0)
            return $"{monster.Name} wins!";
        }
        return "Draw";
       }
    }
}
