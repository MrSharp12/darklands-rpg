using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Darklands.Biz;

namespace DarklandsTests
{
    [TestClass]
    public class FighterTests
    {
        [TestMethod]
        public void InstantiateFighterWillWork()
        {
            var dragonSlayer = new Weapon("DragonSlayer", 45);
            var guts = new Fighter("Guts", 1, dragonSlayer, 15, 5, 0);

            Assert.AreEqual(guts.Name, "Guts");
            Assert.AreEqual(guts.Level, 1);
            Assert.AreEqual(guts.Weapon, "DragonSlayer");
            Assert.AreEqual(guts.HitPoints, 15);
            Assert.AreEqual(guts.Luck, 5);
            Assert.AreEqual(guts.ExperiencePoints, 0);
        }

        
    }
}
