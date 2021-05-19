using System;
using System.Collections.Generic;

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
}
