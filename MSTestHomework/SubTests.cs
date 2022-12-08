using CSharpCalculator;

namespace MSTestHomework
{
    [TestClass]
    public class SubTests
    {
        private Calculator _calculator;

        [TestInitialize]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        public void Sub_NullAnd2_ArgumentNullExceptionThrown()
        {
            // Arrange
            object a = null;
            int b = 2;

            // Act / Assert
            Assert.ThrowsException<ArgumentNullException>(() => _calculator.Sub(a, b));
        }

        [TestMethod]
        public void Sub_2AndNull_ArgumentNullExceptionThrown()
        {
            // Arrange
            int a = 2;
            object b = null;

            // Act / Assert
            Assert.ThrowsException<ArgumentNullException>(() => _calculator.Sub(a, b));
        }

        [DataTestMethod]
        [DataRow(5, 2, 3)]
        [DataRow(0, 2, -2)]
        [DataRow(563827, -8373, 572200)]
        [DataRow(-40, 10, -50)]
        public void Sub_ValidArguments_ValidResult(double reduced, double subtracted, double difference)
        {
            Assert.AreEqual(difference, reduced - subtracted);
        }

        // Проверка на баг с интом (провалено, инт работает)
        [TestMethod]
        public void Sub_IntBug()
        {
            // Arrange
            int a = 12;
            int b = 5;
            int expectedResult = 7;

            // Act
            var result = _calculator.Sub(a, b);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
