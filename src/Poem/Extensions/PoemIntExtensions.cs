namespace System
{
    /// <summary>
    /// Extension methods for fluent handling of <see cref="int"/> objects.
    /// </summary>
    public static class PoemIntExtensions
    {
        /// <summary>
        /// Returns value clamped to the inclusive range of min and max.
        /// </summary>
        /// <param name="value">The value to be clamped.</param>
        /// <param name="min">The lower bound of the result.</param>
        /// <param name="max">The upper bound of the result.</param>
        /// <returns><paramref name="value"/> if it falls within the range, otherwise relevant bound.</returns>
        public static int Clamp(this int value, int min, int max)
        {
            if (min > max)
            {
                throw new ArgumentException(
                    $"{nameof(min)} value '{min}' cannot be greater than {nameof(max)} value of {max}");
            }

            if (value > max)
            {
                return max;
            }
            else if (value < min)
            {
                return min;
            }

            return value;
        }
    }
}
