using System;
using System.Drawing;

namespace BooksGrid.App.Utilities
{
    /// <summary>
    /// Generates a gradient between Green and Red
    /// Green is the low end, Red is the high end
    /// </summary>
    public class RgbGradientGenerator : IGradientGenerator
    {
        ///<inheritdoc cref="IGradientGenerator"/>
        public Color GetColorForValueInRange(double value, double minValue, double maxValue)
        {
            var percent = CalculatePercent(value, minValue, maxValue);

            return GetColorFromPercent(percent);
        }

        /// <summary>
        /// Returns a percentage in the range
        /// If min equals max, return middle range
        /// </summary>
        /// <param name="value">Value to find in range</param>
        /// <param name="minValue">0% of the range</param>
        /// <param name="maxValue">100% of the range</param>
        /// <returns>Percent for the value</returns>
        public double CalculatePercent(double value, double minValue, double maxValue)
        {
            // Avoid division / 0
            if (minValue == maxValue)
            {
                return 0.5;
            }

            double rangeRebased = maxValue - minValue;
            double valueRebased = value - minValue;

            return valueRebased / rangeRebased;
        }

        /// <summary>
        /// Returns the color in the range
        /// 0% is green
        /// 100% is red
        /// </summary>
        /// <param name="percent">Percent of the range</param>
        /// <returns>Color from percent</returns>
        public Color GetColorFromPercent(double percent)
        {
            int red = (int)Math.Round(255 * percent);
            int green = 127 - (int)Math.Round(127 * percent);
            int blue = 0;

            return Color.FromArgb(red, green, blue);
        }
    }
}
