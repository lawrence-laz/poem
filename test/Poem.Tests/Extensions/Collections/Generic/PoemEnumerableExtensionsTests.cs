namespace Poem.Tests.System.Collections.Generic;

public class PoemEnumerableExtensionsTests

{
    [Theory, AutoData]
    public void Calling_foreach_with_action_visits_all_elements(IEnumerable<object> expected)
    {
        // Arrange
        var actual = new List<object>();

        // Act
        expected.ForEach(x => actual.Add(x));

        // Assert
        actual.Should().BeEquivalentTo(expected);
    }

    [Theory, AutoData]
    public void Calling_foreach_with_action_and_index_parameter_visits_all_elements(IEnumerable<object> expected)
    {
        // Arrange
        var actual = new List<object>();

        // Act
        expected.ForEach((x, index) => actual.Add(x));

        // Assert
        actual.Should().BeEquivalentTo(expected);
    }

    [Theory, AutoData]
    public void Calling_foreach_with_action_returns_same_enumerable(IEnumerable<object> expected, Action<object> action)
    {
        // Act
        var actual = expected.ForEach(action);

        // Assert
        actual.Should().BeSameAs(expected);
    }

    [Theory, AutoData]
    public void Calling_foreach_with_action_and_index_parameter_returns_same_enumerable(IEnumerable<object> expected, Action<object, int> action)
    {
        // Act
        var actual = expected.ForEach(action);

        // Assert
        actual.Should().BeSameAs(expected);
    }

    [Theory, AutoData]
    public void Calling_foreach_with_action_and_index_parameter_provides_indices_incrementally(int length)
    {
        // Arrange
        var expected = Enumerable.Range(0, length);
        var actual = new List<object>();

        // Act
        expected.ForEach((_, index) => actual.Add(index));

        // Assert
        actual.Should().BeEquivalentTo(expected);
    }

    [Theory, AutoData]
    public void Calling_foreach_on_null_throws(Action<object> action)
    {
        // Arrange
        IEnumerable<object> enumerable = null;

        // Act & Assert
        enumerable.Invoking(x => x.ForEach(action)).Should().Throw<ArgumentException>();
    }

    [Theory, AutoData]
    public void Calling_foreach_with_null_throws(IEnumerable<object> enumerable)
    {
        // Arrange
        Action<object> action = null;

        // Act & Assert
        enumerable.Invoking(x => x.ForEach(action)).Should().Throw<ArgumentException>();
    }

    [Theory, AutoData]
    public void Calling_foreach_with_index_parameter_on_null_throws(Action<object, int> action)
    {
        // Arrange
        IEnumerable<object> enumerable = null;

        // Act & Assert
        enumerable.Invoking(x => x.ForEach(action)).Should().Throw<ArgumentException>();
    }

    [Theory, AutoData]
    public void Calling_foreach_with_index_parameter_with_null_throws(IEnumerable<object> enumerable)
    {
        // Arrange
        Action<object, int> action = null;

        // Act & Assert
        enumerable.Invoking(x => x.ForEach(action)).Should().Throw<ArgumentException>();
    }
}
