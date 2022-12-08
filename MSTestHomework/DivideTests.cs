using CSharpCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestHomework
{
    [TestClass]
    public class DivideTests
    {
        private Calculator _calculator;

        [TestInitialize]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        public void Divide_Positive()
        {
            // Arrange
            double a = 2.0;
            double b = 5.0;
            double expectedResult = 0.4;

            // Act
            var result = _calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Divide_ArgumentNullExceptionThrown()
        {
            // Arrange
            double a = 5.0;
            double b = 0.0;

            // Act / Assert
            Assert.ThrowsException<ArgumentNullException>(() => _calculator.Divide(b, a));
        }

        [TestMethod]
        public void Divide_WithMinus()
        {
            // Arrange
            double a = 6.0;
            double b = 5.0;
            double expectedResult = 1.2;

            // Act
            var result = _calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        // Проверка на баг с интом (провалено, инт работает)
        [TestMethod]
        public void Divide_IntegerArguments_ValidResult()
        {
            // Arrange
            int a = 10;
            int b = 2;
            int expectedResult = 5;

            // Act
            var result = _calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}