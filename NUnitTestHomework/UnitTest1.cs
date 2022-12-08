using CSharpCalculator;

namespace NUnitTestHomework
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            new Calculator
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}