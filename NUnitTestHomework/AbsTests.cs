using CSharpCalculator;

namespace NUnitTestHomework
{
    internal class AbsTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Abs_Minus5_Result5()
        {
            // Arrange
            int a = -5;
            double expectedResult = 5.0;

            // Act
            var result = _calculator.Abs(a);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Abs_Minus2_Result2()
        {
            // Arrange
            double a = -2.0;
            double expectedResult = 2.0;

            // Act
            var result = _calculator.Abs(a);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Abs_StringArguments_ArgumentExceptionThrown()
        {
            // Arrange  
            object a = "murmuration"; // just google it 
            double expectedResult = 4.0;

            // Act / Assert
            Assert.Throws<ArgumentException>(() => _calculator.Abs(a));
        }

        [Test]
        public void Abs_NullArguments_ArgumentExceptionThrown()
        {
            // Arrange  
            object a = null; 
            double expectedResult = 4.0;

            // Act / Assert
            Assert.Throws<ArgumentNullException>(() => _calculator.Abs(a));
        }
    }
}
