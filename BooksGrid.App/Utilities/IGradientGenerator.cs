using System.Drawing;

namespace BooksGrid.App.Utilities
{
    public interface IGradientGenerator
    {
        /// <summary>
        /// Calculates a color in a gradient
        /// </summary>
        /// <param name="value">Value to convert in gradient</param>
        /// <param name="minValue">Lowest value in gradient</param>
        /// <param name="maxValue">Highest value in gradient</param>
        /// <returns></returns>
        Color GetColorForValueInRange(double value, double minValue, double maxValue);
    }
}
