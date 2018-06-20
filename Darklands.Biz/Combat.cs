using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darklands.Biz
{
    public class Combat
    {

        public static void IsCharacterDead(Character character)
        {
            if (character.HitPoints <= 0)
            {
                character.IsDead = true;
            }
        }
    }
}
