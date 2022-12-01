namespace System.Collections.Generic;

/// <summary>
/// Extension methods for fluent handling of <see cref="IDictionary{TKey, TValue}"/> objects.
/// </summary>
public static class PoemDictionaryExtensions
{
    /// <summary>
    /// Adds a key/value pair to the dictionary by using the specified function if the key does 
    /// not already exist. Returns the new value, or the existing value if the key exists.
    /// </summary>
    /// <param name="dictionary">A dictionary with keys of type TKey and values of type TValue.</param>
    /// <param name="key">The key of the value to get.</param>
    /// <param name="factory">The function used to generate a value for the key.</param>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
    /// <returns>
    /// A TValue instance. When the provided key is in the dictionary, the returned object 
    /// is the value associated with the specified key. When the provided key in not in
    /// the dictionary, the returned object is created using the provided factory and 
    /// added to the dictionary using the provided key.
    /// </returns>
    public static TValue GetOrAdd<TKey, TValue>(
        this IDictionary<TKey, TValue> dictionary,
        TKey key,
        Func<TValue> factory)
    {
        if (dictionary is null)
            throw new ArgumentNullException(nameof(dictionary));

        if (factory is null)
            throw new ArgumentNullException(nameof(factory));

        if (!dictionary.TryGetValue(key, out var value))
        {
            value = factory();
            dictionary.Add(key, value);
        }

        return value;
    }
}
