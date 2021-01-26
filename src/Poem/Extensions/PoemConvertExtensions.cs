namespace System
{
    /// <summary>
    /// Extension methods for fluent handling of <see cref="Convert"/> operations.
    /// </summary>
    public static class PoemConvertExtensions
    {
        /// <inheritdoc cref="Convert.ToBase64String(byte[])"/>
        public static string ToBase64String(this byte[] inArray) => Convert.ToBase64String(inArray);
    }
}
