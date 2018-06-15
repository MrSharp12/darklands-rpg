using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darklands.Biz
{
    class Wizard : Character
    {
        public Wizard(string name, int level, int hitPoints, int luck, int experiencePoints) : base(name, level, hitPoints, luck, experiencePoints)
        {
            Name = name;
            Level = level;
            HitPoints = hitPoints;
            Luck = luck;
            ExperiencePoints = experiencePoints;
        }
    }
}
