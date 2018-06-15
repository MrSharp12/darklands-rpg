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

        public int HitPoints { get;  set; }

        public int Luck { get;  set; }

        public int ExperiencePoints { get;  set; }

       

        public Character(string name, int level, int hitPoints, int luck, int experiencePoints)
        {
        }

        
    }
}
