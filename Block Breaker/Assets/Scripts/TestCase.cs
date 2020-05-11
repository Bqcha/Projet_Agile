using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bacha.Assets.Scripts
{
    [TestFixture]
    class TestCase
    {
        [TestCase]
        public void ScoreZero()
        {
            GameSession gameSession = new GameSession();
            Assert.AreEqual(0, gameSession.ReturnScore());
        }
    }
}
