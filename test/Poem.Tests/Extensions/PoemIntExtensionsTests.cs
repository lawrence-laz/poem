using FluentAssertions;
using Xunit;
using System;

namespace Poem.Tests.Extensions
{
    public class PoemIntExtensionsTests
    {
        [Theory]
        [InlineData(0, 0, 100, 0)]
        [InlineData(100, 0, 100, 100)]
        [InlineData(150, 0, 100, 100)]
        [InlineData(-50, 0, 100, 0)]
        [InlineData(50, 0, 100, 50)]
        public void Calling_clamp_on_value_returns_clamped_value_within_range(
            int value, int min, int max, int expected)
        {
            // Act
            var actual = value.Clamp(min, max);

            // Assert
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(10, 5)]
        public void Calling_clamp_with_min_bigger_than_max_throws(int min, int max)
        {
            // Arrange
            var value = 0;

            // Act & Assert
            value.Invoking(x => x.Clamp(min, max)).Should().ThrowExactly<ArgumentException>();
        }
    }
}
