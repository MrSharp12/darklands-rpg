using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darklands.Biz
{
    public class Fighter : Character
    {
        

        public Fighter(string name, int level, Weapon weapon, int hitPoints, bool isDead, int luck, int experiencePoints) : base(name, level, weapon, hitPoints, isDead, luck, experiencePoints)
        {
            Name = name;
            Level = level;
            Weapon = weapon;
            HitPoints = hitPoints;
            IsDead = isDead;
            Luck = luck;
            ExperiencePoints = experiencePoints;
        }

        

    }
}
