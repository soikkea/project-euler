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
        }

        [Test]
        public void TestProblem002()
        {
            Assert.AreEqual(2u + 8u + 34u, Problem002.run(89u));
        }
    }
}