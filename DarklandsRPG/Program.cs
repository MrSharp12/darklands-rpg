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
            var guts = new Fighter("Guts", 1, 15, 5, 0);
            guts.ShowCharacter();

            Console.ReadLine();
        }
    }
}
