namespace Poem.Tests.Extensions.Collections.Generic;

public class PoemListExtensionsTests
{
    [Theory, AutoData]
    public void Calling_AddToStart_on_null_should_add_element_to_start(IEnumerable<object> expected)
    {
        // Arrange
        var actual = new List<object>(expected.Skip(1));

        // Act
        actual.AddToStart(expected.First());

        // Assert
        actual.Should().BeEquivalentTo(expected);
    }

    [Theory, AutoData]
    public void Calling_AddToStart_on_null_should_throw(object anyItem)
    {
        // Arrange
        List<object> actual = null;

        // Act & Assert
        actual.Invoking(x => x.AddToStart(anyItem))
            .Should().Throw<NullReferenceException>();
    }
}
