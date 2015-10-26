using NUnit.Framework;
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
        [Test]
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
        }
        [Test]
        public void OneStrike()
        {
            Game g = new Game();
            for (int i = 0; i < 20; i++)
            {
                if (i == 4)
                    g.SetPins(0);
                else if (i == 5)
                    g.SetPins(10);
                else
                    g.SetPins(1);
            }
            Assert.That(g.GetFinalScore(), Is.EqualTo(30));
        }
        [Test]
        public void multiSpare()
        {
            Game g = new Game();
            for (int i = 0; i < 20; i++)
            {
                if (i == 4)
                    g.SetPins(3);
                else if (i == 5)
                    g.SetPins(7);
                else if (i == 8)
                    g.SetPins(6);
                else if (i == 9)
                    g.SetPins(4);
                else
                    g.SetPins(1);
            }
            Assert.That(g.GetFinalScore(), Is.EqualTo(38));
        }
        [Test]
        public void multiStrike()
        {
            Game g = new Game();
            for (int i = 0; i < 20; i++)
            {
                if (i == 4)
                    g.SetPins(0);
                else if (i == 5)
                    g.SetPins(10);
                else if (i == 8)
                    g.SetPins(0);
                else if (i == 9)
                    g.SetPins(10);
                else
                    g.SetPins(1);
            }
            Assert.That(g.GetFinalScore(), Is.EqualTo(40));
        }
        [Test]
        public void ContiSpare()
        {
            Game g = new Game();
            for (int i = 0; i < 20; i++)
            {
                if (i == 4)
                    g.SetPins(3);
                else if (i == 5)
                    g.SetPins(7);
                else if (i == 6)
                    g.SetPins(6);
                else if (i == 7)
                    g.SetPins(4);
                else
                    g.SetPins(1);
            }
            Assert.That(g.GetFinalScore(), Is.EqualTo(43));
        }
        [Test]
        public void ContiStrike()
        {
            Game g = new Game();
            for (int i = 0; i < 20; i++)
            {
                if (i == 4)
                    g.SetPins(0);
                else if (i == 5)
                    g.SetPins(10);
                else if (i == 6)
                    g.SetPins(0);
                else if (i == 7)
                    g.SetPins(10);
                else if (i == 8)
                    g.SetPins(0);
                else if (i == 9)
                    g.SetPins(10);
                else
                    g.SetPins(1);
            }
            Assert.That(g.GetFinalScore(), Is.EqualTo(77));
        }
        [Test]
        public void Test1()
        {
            Game g = new Game();
             g.SetPins(0);
             g.SetPins(10);
             g.SetPins(9);
             g.SetPins(1);
             g.SetPins(0);
             g.SetPins(10);
             g.SetPins(7);
             g.SetPins(3);
             g.SetPins(0);
             g.SetPins(10);
             g.SetPins(2);
             g.SetPins(8);
             g.SetPins(0);
             g.SetPins(10);
             g.SetPins(5);
             g.SetPins(5);
             g.SetPins(0);
             g.SetPins(10);
             g.SetPins(1);
             g.SetPins(9);
             g.SetPins(10);
            
            Assert.That(g.GetFinalScore(), Is.EqualTo(200));
        }
        [Test]
        public void Test2()
        {
            Game g = new Game();
            g.SetPins(0);
            g.SetPins(10);
            g.SetPins(0);
            g.SetPins(10);
            g.SetPins(0);
            g.SetPins(10);
            g.SetPins(0);
            g.SetPins(10);
            g.SetPins(0);
            g.SetPins(10);
            g.SetPins(0);
            g.SetPins(10);
            g.SetPins(0);
            g.SetPins(10);
            g.SetPins(0);
            g.SetPins(10);
            g.SetPins(0);
            g.SetPins(10);
            g.SetPins(10);
            g.SetPins(10);
            g.SetPins(10);

            Assert.That(g.GetFinalScore(), Is.EqualTo(300));
        }
    }
}
