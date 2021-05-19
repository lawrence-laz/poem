namespace System
{
    /// <summary>
    /// Extension methods for fluent handling of <see cref="Enum"/> objects.
    /// </summary>
    public static class PoemEnumExtensions
    {
        /// <inheritdoc cref="Enum.Parse(Type, string)"/>
        public static object ParseEnum(this string value, Type enumType)
        {
            return Enum.Parse(enumType, value);
        }

        /// <summary>
        /// Converts the string representation of the name or numeric value of one or more
        /// enumerated constants to an equivalent enumerated object.
        /// </summary>
        /// <typeparam name="T">The enumeration type to which to convert value.</typeparam>
        /// <param name="value">A string containing the name or value to convert.</param>
        /// <returns>An object of specified type whose value is represented by value.</returns>
        public static T ParseEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value);
        }
    }
}
