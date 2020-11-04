using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

namespace Lab10.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        
        [Test]
        public void Sample_Test()
        {
            var expected = 5;
            var actual = 2;

            Assert.AreEqual(expected, actual);
        }
    }
}