namespace Poem.Tests.Extensions;

public class PoemRangeExtensionsTests
{
    [Theory]
    [InlineData(1, 10, 2, 9, true)]
    [InlineData(1, 10, 1, 10, true)]
    [InlineData(1, 10, 5, 15, false)]
    [InlineData(5, 6, 1, 10, false)]
    public void Contains_WithTwoRanges_SouldReturnTrueWhenFirstContainsSecond(
        int rangeStart,
        int rangeEnd,
        int otherRangeStart,
        int otherRangeEnd,
        bool expected)
    {
        // Arraange
        var range = rangeStart..rangeEnd;
        var otherRange = otherRangeStart..otherRangeEnd;
        // Act & Assert
        range.Contains(otherRange).Should().Be(expected);
    }

    [Theory]
    [InlineData(1, 10, 2, 9, true)]
    [InlineData(1, 10, 1, 10, true)]
    [InlineData(1, 10, 5, 15, false)]
    [InlineData(5, 6, 1, 10, true)]
    public void Foo(int rangeStart, int rangeEnd, int otherRangeStart, int otherRangeEnd, bool expected)
    {
        // Arraange
        var range = rangeStart..rangeEnd;
        var otherRange = otherRangeStart..otherRangeEnd;
        // Act & Assert
        range.ContainsOrIsContainedBy(otherRange).Should().Be(expected);
    }
}
