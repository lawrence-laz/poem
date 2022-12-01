namespace Poem.Tests.Extensions.Collections.Generic;

public class PoemIntEnumerableExtensionsTests
{
    [Theory, AutoData]
    public void OrderBy_WithNonNull_ShouldBehaveLikeStandardOrderBy(IEnumerable<int> sut)
    {
        // Arrange
        var expected = sut.OrderBy(x => x);

        // Act
        var actual = sut.OrderBy();

        // Assert
        actual.Should().BeEquivalentTo(expected, o => o.WithStrictOrdering());

    }

    [Theory, AutoData]
    public void OrderByDescending_WithNonNull_ShouldBehaveLikeStandardOrderBy(IEnumerable<int> sut)
    {
        // Arrange
        var expected = sut.OrderByDescending(x => x);

        // Act
        var actual = sut.OrderByDescending();

        // Assert
        actual.Should().BeEquivalentTo(expected, o => o.WithStrictOrdering());

    }

    [Fact]
    public void OrderBy_WithNull_ShouldThrow()
    {
        // Arrange
        IEnumerable<int> sut = null;

        // Act & Assert
        sut.Invoking(x => x.OrderBy()).Should().Throw<ArgumentNullException>();
    }

    [Fact]
    public void OrderByDescending_WithNull_ShouldThrow()
    {
        // Arrange
        IEnumerable<int> sut = null;

        // Act & As < ert
        sut.Invoking(x => x.OrderByDescending()).Should().Throw<ArgumentNullException>();
    }
}

