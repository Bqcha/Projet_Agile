using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCasea
{
    [TestFixture]
    class TestCase
    {
        [TestCase]
        public void addScore()
        {
            GameSession gameSession = new GameSession();
            Assert.AreEqual(gameSession.ReturnScore(),0);

        }
    }
}
