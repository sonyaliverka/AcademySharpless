using CSharpCalculator;

namespace NUnitTestHomework
{

    [TestFixture]
    public class PowTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Pow_2And2_Result4()
        {
            // Arrange
            int a = 2;
            double b = 2.0;
            double expectedResult = 4.0;

            // Act
            var result = _calculator.Pow(a, b);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Pow_DoubleArgument_ArgumentExeptionThrown()
        {
            // Arrange
            double a = 2.0;
            double b = 2.0;

            // Act / Assert
            Assert.Throws<ArgumentException>(() => _calculator.Pow(b, a));
        }

        [Test]
        public void Pow_StringArguments_ArgumentExceptionThrown()
        {
            // Arrange  
            object a = "Knock, knock.";
            object b = "Who's there?";

            // Act / Assert
            Assert.Throws<ArgumentException>(() => _calculator.Pow(b, a));
        }

        [Test]
        public void Pow_NullArguments_ArgumentExceptionThrown()
        {
            // Arrange  
            object a = null;
            object b = 2.0;

            // Act / Assert
            Assert.Throws<ArgumentNullException>(() => _calculator.Pow(b, a));
        }
    }
}


