using CSharpCalculator;

namespace NUnitTestHomework
{
    [TestFixture]
    [Parallelizable]
    internal class SqrtTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Sqrt_StringArguments_ArgumentExceptionThrown()
        {
            // Arrange
            object a = "Asparagus, asparagus. Put us on your table."; // Asparagus, asparagus. We'll make you feel more able.

            // Act / Assert
            Assert.Throws<ArgumentException>(() => _calculator.Sqrt(a));
        }

        [Test]
        public void Sqrt_4_Result2()
        {
            // Arrange
            double a = 4.0;
            double expectedResult = 2.0;

            // Act
            var result = _calculator.Sqrt(a);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }


    }
}
