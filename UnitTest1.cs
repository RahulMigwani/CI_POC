using System;
using NUnit.Framework;

namespace CI_Test.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
        }

        [Test]
        public void TestMethod2()
        {

            throw new Exception();
        }
    }
}
