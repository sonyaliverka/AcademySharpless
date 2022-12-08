using CSharpCalculator;

namespace MSTestHomework
{
    [TestClass]
    public class MultiplyTests
    {
        private Calculator _calculator;

        [TestInitialize]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        [DataTestMethod]
        [DataRow(10, 10, 100)]
        [DataRow(20, 0, 0)]
        [DataRow(0, 20, 0)]
        [DataRow(0, 0, 0)]
        [DataRow(-20, 1, -20)]
        public void MultiplyParameterizedTest(int multiplicative, int multiplier, int product)
        {
            // Act / Assert
            Assert.AreEqual(product, _calculator.Multiply(multiplicative, multiplier));
        }

        // Проверка на баг с интом (провалено, инт работает)
        [TestMethod]
        public void Multiply_IntBug()
        {
            // Arrange
            int a = 5;
            int b = 2;
            int expectedResult = 10;

            // Act
            var result = _calculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

    }
}
