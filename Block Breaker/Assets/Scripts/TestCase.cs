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
           
            Assert.AreEqual(0, 0);
        }
    }
}
