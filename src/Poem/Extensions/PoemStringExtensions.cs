﻿namespace System
{
    /// <summary>
    /// Extension methods for fluent handling of <see cref="string"/> objects.
    /// </summary>
    public static class PoemStringExtensions
    {
        /// <inheritdoc cref="string.IsNullOrEmpty(string)"/>
        public static bool IsNullOrEmpty(this string value) => string.IsNullOrEmpty(value);

        /// <inheritdoc cref="string.IsNullOrWhiteSpace(string)"/>
        public static bool IsNullOrWhiteSpace(this string value) => string.IsNullOrWhiteSpace(value);
    }
}