using BooksGrid.App.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace BooksGrid.Tests.App.Utilities
{
    [TestClass]
    public class RgbGradientGeneratorTests
    {
        [TestMethod]
        public void RgbGradientGenerator_GetColorForValueInRange_GeneratesColor()
        {
            // Arrange
            var generator = new RgbGradientGenerator();
            var lowGradientColor = Color.FromArgb(0, 127, 0);
            var midGradientColor = Color.FromArgb(128, 63, 0);
            var highGradientColor = Color.FromArgb(255, 0, 0);


            // Act
            var lowColor = generator.GetColorForValueInRange(20, 20, 30);
            var midColor = generator.GetColorForValueInRange(25, 20, 30);
            var highColor = generator.GetColorForValueInRange(30, 20, 30);

            // Assert
            Assert.AreEqual(lowGradientColor, lowColor);
            Assert.AreEqual(midGradientColor, midColor);
            Assert.AreEqual(highGradientColor, highColor);
        }

        [DataTestMethod]
        [DataRow(12.1, 12.1, 27.7, 0)]
        [DataRow(25, 0, 100, 0.25)]
        [DataRow(20, 10, 30, 0.5)]
        [DataRow(21, 12, 24, 0.75)]
        [DataRow(35.9, 12.5, 35.9, 1)]
        [DataRow(10, 10, 10, 0.5)]
        public void RgbGradientGenerator_CalculatePercent_CalculatesMultiplePercents(double value, double minValue, double maxValue, double expected)
        {
            // Arrange
            var generator = new RgbGradientGenerator();

            // Act
            var percent = generator.CalculatePercent(value, minValue, maxValue);

            // Assert
            Assert.AreEqual(expected, percent);
        }

        [DataTestMethod]
        [DataRow(0, 0, 127, 0)]
        [DataRow(0.25, 64, 95, 0)]
        [DataRow(0.5, 128, 63, 0)]
        [DataRow(0.75, 191, 32, 0)]
        [DataRow(1, 255, 0, 0)]
        public void RgbGradientGenerator_GetColorFromPercent_TransformsPercentsInColors(double percent, int expectedR, int expectedG, int expectedB)
        {
            // Arrange
            var generator = new RgbGradientGenerator();

            // Act
            var color = generator.GetColorFromPercent(percent);

            // Assert
            Assert.AreEqual(expectedR, color.R);
            Assert.AreEqual(expectedG, color.G);
            Assert.AreEqual(expectedB, color.B);
        }
    }
}
