namespace System.Collections.Generic
{
    /// <summary>
    /// Extension methods for fluent handling of <see cref="IEnumerable{T}"/> objects.
    /// </summary>
    public static class PoemEnumerableExtensions
    {
        /// <summary>
        /// Performs the specified action on each element of the <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <typeparam name="T">Type of the generic <paramref name="enumerable"/> parameter.</typeparam>
        /// <param name="enumerable">The collection of elements to perform <paramref name="action"/> on.</param>
        /// <param name="action">The <see cref="Action{T1}"/> delegate to perform on each element of the <paramref name="enumerable"/>.</param>
        /// <returns>The same <paramref name="enumerable"/> as supplied to parameter.</returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            if (enumerable is null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (action is null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            foreach (var item in enumerable)
            {
                action(item);
            }

            return enumerable;
        }

        /// <summary>
        /// Performs the specified action on each element of the <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <typeparam name="T">Type of the generic <paramref name="enumerable"/> parameter.</typeparam>
        /// <param name="enumerable">The collection of elements to perform <paramref name="action"/> on.</param>
        /// <param name="action">The <see cref="Action{T1, T2}"/> delegate to perform on each element of the <paramref name="enumerable"/>. The first parameter is the element, the second is the element's index in the collection.</param>
        /// <returns>The same <paramref name="enumerable"/> as supplied to parameter.</returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> enumerable, Action<T, int> action)
        {
            if (enumerable is null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (action is null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            var index = 0;
            foreach (var item in enumerable)
            {
                action(item, index++);
            }

            return enumerable;
        }

        /// <summary>
        /// Performs the specified action on each element of the <see cref="IEnumerable{T}"/>. 
        /// In case of exceptions continues iterating till the end and then throws an <see cref="AggregateException"/>.
        /// </summary>
        /// <typeparam name="T">Type of the generic <paramref name="enumerable"/> parameter.</typeparam>
        /// <param name="enumerable">The collection of elements to perform <paramref name="action"/> on.</param>
        /// <param name="action">The <see cref="Action{T1}"/> delegate to perform on each element of the <paramref name="enumerable"/>.</param>
        /// <returns>The same <paramref name="enumerable"/> as supplied to parameter.</returns>
        public static IEnumerable<T> ForEachWithAggregatedExceptions<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            if (enumerable is null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (action is null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            List<Exception> exceptions = null;

            foreach (var item in enumerable)
            {
                try
                {
                    action(item);
                }
                catch(Exception e)
                {
                    if (exceptions is null)
                    {
                        exceptions = new List<Exception>();
                    }

                    exceptions.Add(e);
                }
            }

            if (exceptions?.Count > 0)
            {
                throw new AggregateException(exceptions);
            }

            return enumerable;
        }
    }
}
