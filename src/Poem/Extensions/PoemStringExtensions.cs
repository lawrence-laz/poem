/// <summary>
/// Extension methods for fluent handling of <see cref="string"/> objects.
/// </summary>
public static class PoemStringExtensions
{
    /// <inheritdoc cref="string.IsNullOrEmpty(string)"/>
    public static bool IsNullOrEmpty(this string value) => string.IsNullOrEmpty(value);

    /// <inheritdoc cref="string.IsNullOrWhiteSpace(string)"/>
    public static bool IsNullOrWhiteSpace(this string value) => string.IsNullOrWhiteSpace(value);

    /// <inheritdoc cref="string.Join(string, IEnumerable{string})"/>.
    public static string Join(this IEnumerable<string> values, string separator) => string.Join(separator, values);

    /// <summary>
    /// Removes all trailing occurrences of a specified string.
    /// </summary>
    /// <param name="currentValue">A string to be trimmed.</param>
    /// <param name="trimString">A string to remove.</param>
    /// <returns>
    /// The string that remains after all occurrences of the <paramref name="trimString"/>
    /// are removed from the end of the current string. If <paramref name="trimString"/> is 
    /// null or an empty string, Unicode white-space characters are removed instead. If no
    /// characters can be trimmed from the current instance, the method returns the current
    /// instance unchanged.
    /// </returns>
    public static string TrimEnd(this string currentValue, string trimString = null)
    {
        if (currentValue is null)
        {
            throw new ArgumentNullException(nameof(currentValue));
        }

        if (trimString.IsNullOrEmpty())
        {
            return currentValue.TrimEnd(trimChars: null);
        }

        while (currentValue.EndsWith(trimString))
        {
            currentValue = currentValue.Substring(0, currentValue.Length - trimString.Length);
        }

        return currentValue;
    }

    /// <summary>
    /// Removes all preceding occurrences of a specified string.
    /// </summary>
    /// <param name="currentValue">A string to be trimmed.</param>
    /// <param name="trimString">A string to remove.</param>
    /// <returns>
    /// The string that remains after all occurrences of the <paramref name="trimString"/>
    /// are removed from the start of the current string. If <paramref name="trimString"/> is 
    /// null or an empty string, Unicode white-space characters are removed instead. If no
    /// characters can be trimmed from the current instance, the method returns the current
    /// instance unchanged.
    /// </returns>
    public static string TrimStart(this string currentValue, string trimString = null)
    {
        if (currentValue is null)
        {
            throw new ArgumentNullException(nameof(currentValue));
        }

        if (trimString.IsNullOrEmpty())
        {
            return currentValue.TrimStart(trimChars: null);
        }

        while (currentValue.StartsWith(trimString))
        {
            currentValue = currentValue.Substring(trimString.Length, currentValue.Length - trimString.Length);
        }

        return currentValue;
    }

    /// <summary>
    /// Compares two strings disregarding their casing (using <see cref="StringComparison.OrdinalIgnoreCase"/>).
    /// </summary>
    /// <param name="left">First string to be compared against the second one.</param>
    /// <param name="right">Second string to be compared against the first one.</param>
    /// <returns>True if provided strings are equal, false otherwise.</returns>
    public static bool EqualsIgnoreCase(this string left, string right)
    {
        if (left is null)
        {
            throw new ArgumentNullException(nameof(left));
        }

        if (right is null)
        {
            throw new ArgumentNullException(nameof(right));
        }

        return string.Equals(left, right, StringComparison.OrdinalIgnoreCase);
    }
}
