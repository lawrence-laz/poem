namespace System.Collections.Generic
{
    /// <summary>
    /// Extension methods for fluent handling of <see cref="IList{T}"/> objects.
    /// </summary>
    public static class PoemListExtensions
    {
        /// <summary>
        /// Inserts an item to the start of the <see cref="IList{T}"/>.
        /// </summary>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        /// <param name="list">The list to add element to.</param>
        /// <param name="item">The object to insert into the <see cref="IList{T}"/>.</param>
        /// <returns>The same <paramref name="list"/> as supplied to parameter.</returns>
        public static IList<T> AddToStart<T>(this IList<T> list, T item)
        {
            list.Insert(0, item);

            return list;
        }
    }
}
