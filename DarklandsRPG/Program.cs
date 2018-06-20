using Darklands.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarklandsRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            var dragonSlayer = new Weapon("DragonSlayer", 45);
            var guts = new Fighter("Guts", 1, dragonSlayer, 15, false, 5, 0);
            var skeleton = new Enemy("Skeleton", 12, false, 8);

            //guts.Attack(dragonSlayer, skeleton);
            //Console.WriteLine($"{guts.Name} attacks!  {skeleton.Type} has {skeleton.HitPoints}");

            skeleton.Attack(8, guts);
            Console.WriteLine($"Skeleton attacks!  Guts has {guts.HitPoints}");
            



            Console.ReadLine();
        }
    }
}
