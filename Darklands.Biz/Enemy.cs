using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darklands.Biz
{
    public class Enemy 
    {
        public string Type { get; set; }

        public int HitPoints { get; set; }

        public bool IsDead { get; set; }

        public int ExperiencePointValue { get; set; }

        public Enemy(string type, int hitPoints, bool isDead, int experiencePointValue)
        {
            Type = type;
            HitPoints = hitPoints;
            IsDead = isDead;
            ExperiencePointValue = experiencePointValue;
        }

        public void Attack(int damagePoints, Character target)
        {
            var randomNumber = new Random(Guid.NewGuid().GetHashCode());
            var damage = randomNumber.Next(1, damagePoints);
            target.HitPoints -= damage;
        }
    }
}
