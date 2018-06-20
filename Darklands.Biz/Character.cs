using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darklands.Biz
{
     public abstract class Character
    {
        public string Name { get;  set; }

        public int Level { get;  set; }

        public Weapon Weapon { get; set; }

        public int HitPoints { get;  set; }

        public bool IsDead { get; set; }

        public int Luck { get;  set; }

        public int ExperiencePoints { get;  set; }

        public Character(string name, int level, Weapon weapon, int hitPoints, bool isDead, int luck, int experiencePoints)
        {
            Name = name;
            Level = level;
            Weapon = weapon;
            HitPoints = hitPoints;
            IsDead = isDead;
            Luck = luck;
            ExperiencePoints = experiencePoints;
        }

        public void Attack(Weapon weapon, Enemy target)
        {
            var randomNumber = new Random(Guid.NewGuid().GetHashCode());
            var damage = randomNumber.Next(1, weapon.MaxDamage);
            target.HitPoints -= damage;
        }
    }
}
