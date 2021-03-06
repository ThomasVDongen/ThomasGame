﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameSE2;
using GameSE2.Classes;
using System.Drawing;
using System.Runtime.InteropServices;

namespace UnitTestProjectGame
{
    [TestClass]
    public class UnitTest1
    {
        private Graphics g;
        private Point p;
        private bool bl2;
        private int hitp2;
        [TestMethod]
        public void TestMethodPlayer()
        {
            Point point = new Point(23, 32);
            bool bl1 = false;
            int hitpoints = 20;
            Player player = new Player(bl1, hitpoints,point);
            player.Draw(g);
            player.Update();
            player.Interaction(2);
            player.HitPoints = 19;
            player.Position = new Point(10,1);
            player.PowerUp = true;
            p = player.Position;
            bl2 = player.PowerUp;
            hitp2 = player.HitPoints;
        }
        [TestMethod]
        public void TestMethodEnemy()
        {
            Point point = new Point(23, 32);
            int hitpoints = 20;
            Enemy enemy = new Enemy(point, hitpoints);
            p = enemy.Position;
            hitp2 = enemy.HitPoints;
            enemy.HitPoints = 19;
            enemy.Position = new Point(10,1);
            enemy.Attack(new Player(false, 18, point));
            enemy.Draw(g);
            enemy.Update();


        }

        [TestMethod]
        public void TestMethodEntity()
        {
            Entity entity = new Entity();
        }

        [TestMethod]
        public void TestMethodVector()
        {
            Vector vector = new Vector();
        }

        [TestMethod]
        public void TestMethodCharacter()
        {
            Character character = new Character(p, hitp2);
        }
    }
}
