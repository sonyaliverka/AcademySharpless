using CSharpCalculator;

namespace MSTestHomework
{
    [TestClass]
    public class AddTests
    {
        private Calculator _calculator;

        [TestInitialize]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        public void Add_2And5_7Returned()
        {
            // Arrange
            double a = 2.0;
            double b = 5.0;
            double expectedResult = 7.0;

            // Act
            var result = _calculator.Add(a, b);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Add_NullAnd5_ArgumentNullExceptionThrown()
        {
            // Arrange
            object a = null;
            double b = 5.0;

            // Act / Assert
            Assert.ThrowsException<ArgumentNullException>(() => _calculator.Add(a, b));
        }

        [TestMethod]
        public void Add_0And5_5Returned()
        {
            // Arrange
            object a = 0.0;
            double b = 5.0;
            double expectedResult = 5.0;

            // Act
            var result = _calculator.Add(a, b);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        // Проверка на баг с интом (успешно)
        [TestMethod]
        public void Add_IntegerArguments_ValidResult()
        {
            // Arrange
            int a = 5;
            int b = 5;
            int expectedResult = 10;

            // Act
            var result = _calculator.Add(a, b);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

    }
}


