﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bowling
{
    [TestFixture]
    public class TestBowling
    {
        [Test]
        public void AllZero()
        {
            Game g = new Game();
            for (int i = 0; i < 20; i++)
            {
                g.SetPins(0);
            }
            Assert.That(g.GetFinalScore(), Is.EqualTo(0));
        }
        [Test]
        public void AllOne()
        {
            Game g = new Game();
            for (int i = 0; i < 20; i++)
            {
                g.SetPins(1);
            }
            Assert.That(g.GetFinalScore(), Is.EqualTo(20));
        }
        /*[Test]
        public void OneSpare()
        {
            Game g = new Game();
            for (int i = 0; i < 20; i++)
            {
                if (i == 4)
                    g.SetPins(9);
                else
                g.SetPins(1);
                

            }
            Assert.That(g.GetFinalScore(), Is.EqualTo(29));
        }*/
    }
}
