namespace System;

/// <summary>
/// Extension methods for fluent handling of <see cref="float"/> objects.
/// </summary>
public static class PoemFloatExtensions
{
    /// <inheritdoc cref="float.Parse(string, IFormatProvider)"/>
    public static float ParseFloat(this string s, IFormatProvider provider) => float.Parse(s, provider);

    /// <inheritdoc cref="float.Parse(string, NumberStyles, IFormatProvider)"/>
    public static float ParseFloat(this string s, NumberStyles style, IFormatProvider provider) => float.Parse(s, style, provider);

    /// <inheritdoc cref="float.Parse(string, NumberStyles)"/>
    public static float ParseFloat(this string s, NumberStyles style) => float.Parse(s, style);

    /// <inheritdoc cref="float.Parse(string)"/>
    public static float ParseFloat(this string s) => float.Parse(s);
}
