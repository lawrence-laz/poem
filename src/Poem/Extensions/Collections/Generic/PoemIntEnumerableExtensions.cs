namespace System.Collections.Generic;

/// <summary>
/// Extension methods for fluent handling of <see cref="IEnumerable{T}"/> objects.
/// </summary>
public static class PoemIntEnumerableExtensions
{
    /// <summary>
    /// Orders the collection of numbers in ascending order.
    /// </summary>
    /// <param name="enumerable">The collection of numbers to order</param>
    /// <returns>The ordered collection of numbers</returns>
    public static IEnumerable<int> OrderBy(this IEnumerable<int> enumerable)
    {
        if (enumerable is null)
        {
            throw new ArgumentNullException(nameof(enumerable));
        }

        return enumerable.OrderBy(number => number);
    }

    /// <summary>
    /// Orders the collection of numbers in descending order.
    /// </summary>
    /// <param name="enumerable">The collection of numbers to order</param>
    /// <returns>The ordered collection of numbers</returns>
    public static IEnumerable<int> OrderByDescending(this IEnumerable<int> enumerable)
    {
        if (enumerable is null)
        {
            throw new ArgumentNullException(nameof(enumerable));
        }

        return enumerable.OrderByDescending(number => number);
    }
}

