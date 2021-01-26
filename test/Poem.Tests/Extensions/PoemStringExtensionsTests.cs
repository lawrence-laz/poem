using FluentAssertions;
using System;
using Xunit;

namespace Poem.Tests.Extensions
{
    public class PoemStringExtensionsTests
    {
        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        [InlineData("Foo")]
        public void Calling_IsNullOrEmpty_return_same_as_standard(string text)
        {
            // Arrange
            var expected = string.IsNullOrEmpty(text);

            // Act
            var actual = text.IsNullOrEmpty();

            // Arrange
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        [InlineData("Foo")]
        public void Calling_IsNullOrWhiteSpace_return_same_as_standard(string text)
        {
            // Arrange
            var expected = string.IsNullOrWhiteSpace(text);

            // Act
            var actual = text.IsNullOrWhiteSpace();

            // Arrange
            actual.Should().Be(expected);
        }


    }
}
