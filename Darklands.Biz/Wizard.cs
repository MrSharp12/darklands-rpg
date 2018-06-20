using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darklands.Biz
{
    class Wizard : Character
    {
        public Wizard(string name, int level, Weapon weapon, int hitPoints, bool isDead, int luck, int experiencePoints) : base(name, level, weapon, hitPoints, isDead, luck, experiencePoints)
        {
            Name = name;
            Level = level;
            Weapon = weapon;
            HitPoints = hitPoints;
            Luck = luck;
            ExperiencePoints = experiencePoints;
        }
    }
}
