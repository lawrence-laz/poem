namespace System;
/// <summary>
/// Extension methods for fluent handling of <see cref="System.Range"/> structs.
/// </summary>
public static class PoemRangeExtensions
{
    /// <summary>
    /// Checks if the current <paramref name="range"/> contains the <paramref name="other"/> range.
    /// </summary>
    /// <param name="range">The first range to check against.</param>
    /// <param name="other">The other range to check against.</param>
    /// <returns>True if either of the ranges contain each other, false otherwise.</returns>
    public static bool Contains(this Range range, Range other)
    {
        return range.Start.Value <= other.Start.Value
            && range.End.Value >= other.End.Value;
    }

    /// <summary>
    /// Checks if either the current <paramref name="range"/> contains the <paramref name="other"/> range,
    /// or the <paramref name="other"/> range contains the current <paramref name="range"/>.
    /// </summary>
    /// <param name="range">The first range to check against.</param>
    /// <param name="other">The other range to check against.</param>
    /// <returns>True if either of the ranges contain each other, false otherwise.</returns>
    public static bool ContainsOrIsContainedBy(this Range range, Range other)
    {
        return range.Contains(other) || other.Contains(range);
    }
}
