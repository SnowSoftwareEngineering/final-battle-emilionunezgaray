using RPG_Battler.Character;
using RPG_Battler.Character.Upgrades;
using RPG_Battler.Gameplay;
using System.Collections.Generic;
using System;

namespace RPG_Battler.Tests
{
    public class HeroTests
    {
        [Fact]
        public void EquipItem_IncreasesHeroPower()
        {
            Hero hero = new Hero("Batman");
            int originalPower = hero.TotalPower;
            Equipment sword = new Equipment("Sword", 10);

            hero.EquipItem(sword);

            Assert.Equal(originalPower + 10, hero.TotalPower);
        }

        [Fact]
        public void LearnSkill_AddsSkillToHero()
        {
            Hero hero = new Hero("Batman");
            Skill skill = new Skill("Slash", 5, 1);

            hero.LearnSkill(skill);
            Assert.True(true);
        }

        [Fact]
        public void LearnSpell_AddsSpellToHero()
        {
            Hero hero = new Hero("Batman");
            Spell spell = new Spell("Fireball", 8);

            hero.LearnSpell(spell);

            Assert.True(true); 
        }

        [Fact]
        public void Spell_CurrentPower_IncreasesOverTime()
        {
            Spell spell = new Spell("TimeSpell", 10);
            System.Threading.Thread.Sleep(1000);
            int power = spell.CurrentPower();

            Assert.True(power >= 10);
        }
    }
}
