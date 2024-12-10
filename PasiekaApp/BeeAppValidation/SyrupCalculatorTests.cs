using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobileApp.ApiaryTools;
using MobileApp.Helpers;

namespace BeeAppValidation
{
    [TestClass]
    public class SyrupCalculatorTests
    {
        [TestMethod]
        public void CalculateSyrup_OneToOne_ForSugar_ReturnsCorrectValues()
        {
            // Arrange
            var calculator = new ApiaryToolHelper(); // Zakładamy, że metoda znajduje się w tej klasie.
            double targetValue = 100;
            var baseType = SyrupCalculationBaseType.ForSugar;
            var ratioType = SyrupCalculationRatioType.OneToOne;

            // Act
            var result = calculator.CalculateSyrup(targetValue, baseType, ratioType);

            // Assert
            Assert.AreEqual(100, result.Item1); // Water
            Assert.AreEqual(100, result.Item2); // Sugar
            Assert.AreEqual(160, result.Item3); // Syrup
        }

        [TestMethod]
        public void CalculateSyrup_TwoToOne_ForSyrup_ReturnsCorrectValues()
        {
            // Arrange
            var calculator = new ApiaryToolHelper();
            double targetValue = 240;
            var baseType = SyrupCalculationBaseType.ForSyrup;
            var ratioType = SyrupCalculationRatioType.TwoToOne;

            // Act
            var result = calculator.CalculateSyrup(targetValue, baseType, ratioType);

            // Assert
            Assert.AreEqual(100, result.Item1); // Water
            Assert.AreEqual(200, result.Item2); // Sugar
            Assert.AreEqual(240, result.Item3); // Syrup
        }

        [TestMethod]
        public void CalculateSyrup_ThreeToTwo_ForSugar_ReturnsCorrectValues()
        {
            // Arrange
            var calculator = new ApiaryToolHelper();
            double targetValue = 300;
            var baseType = SyrupCalculationBaseType.ForSugar;
            var ratioType = SyrupCalculationRatioType.ThreeToTwo;

            // Act
            var result = calculator.CalculateSyrup(targetValue, baseType, ratioType);

            // Assert
            Assert.AreEqual(200, result.Item1); // Water
            Assert.AreEqual(300, result.Item2); // Sugar
            Assert.AreEqual(400, result.Item3); // Syrup
        }
    }
}
