using NUnit.Framework;
using Problems;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestProblem001()
        {
            Assert.AreEqual(23u, Problem001.run(10));
            Assert.AreEqual(233168u, Problem001.run());
        }

        [Test]
        public void TestProblem002()
        {
            Assert.AreEqual(2u + 8u + 34u, Problem002.run(89u));
            Assert.AreEqual(4613732u, Problem002.run());
        }

        [Test]
        public void TestProblem006()
        {
            Assert.AreEqual(2640u, Problem006.run(10u));
            Assert.AreEqual(25164150u, Problem006.run());
        }

        [Test]
        public void TestProblem008()
        {
            Assert.AreEqual(5832u, Problem008.run(4u));
            Assert.AreEqual(23514624000ul, Problem008.run());
        }

        [Test]
        public void TestProblem014()
        {
            Assert.AreEqual(1u, Problem014.run(1u));
            Assert.AreEqual(3u, Problem014.run(5u));
            Assert.AreEqual(837799u, Problem014.run());
        }

        [Test]
        public void TestProblem018()
        {
            uint[,] triangle = new uint[4, 4] {
                {3, 0, 0, 0},
                {7, 4, 0, 0},
                {2, 4, 6, 0},
                {8, 5, 9, 3}
            };
            Assert.AreEqual(23u, Problem018.run(triangle));
            Assert.AreEqual(1074u, Problem018.run());
        }
    }
}