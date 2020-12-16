using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RRGame.GameEngine;

namespace GameTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOne()
        {
            BulletCylinder cylinder = new BulletCylinder();
            cylinder.LoadBullet(2);
            Assert.AreEqual(cylinder.FireBullet(0), false);
        }

        [TestMethod]
        public void TestTwo()
        {
            BulletCylinder cylinder = new BulletCylinder();
            cylinder.LoadBullet(0);
            Assert.AreEqual(cylinder.FireBullet(0), true);
        }
    }
}
