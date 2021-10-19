using AutoFixture.Xunit2;
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

        [Theory]
        [AutoData]
        public void Calling_join_on_a_string_array_with_multichar_separator_returns_a_single_string(
            string[] values, string separator)
        {
            // Arrange
            var expected = string.Join(separator, values);

            // Act
            var actual = values.Join(separator);

            // Assert
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData("", "bar", "")]
        [InlineData("foobar", "bar", "foo")]
        [InlineData("foobarbar", "bar", "foo")]
        [InlineData("foobar", "fizz", "foobar")]
        [InlineData("  foo   ", "", "  foo")]
        [InlineData("  foo   ", null, "  foo")]
        public void Calling_trim_end_on_a_string_with_a_string_should_remove_all_occurances_or_remove_whitespaces_if_trim_string_is_null(
            string currentValue, string trimString, string expected)
        {
            // Act
            var actual = currentValue.TrimEnd(trimString);

            // Assert
            actual.Should().Be(expected);
        }

        [Theory]
        [AutoData]
        public void Calling_trim_end_on_a_null_should_throw(string trimString)
        {
            // Arrange
            string nullValue = null;

            // Act & Assert
            nullValue.Invoking(x => x.TrimEnd(trimString))
                .Should().ThrowExactly<ArgumentNullException>();
        }

        [Theory]
        [InlineData("", "bar", "")]
        [InlineData("foobar", "foo", "bar")]
        [InlineData("foofoobar", "foo", "bar")]
        [InlineData("foobar", "fizz", "foobar")]
        [InlineData("   foo  ", "", "foo  ")]
        [InlineData("   foo  ", null, "foo  ")]
        public void Calling_trim_start_on_a_string_with_a_string_should_remove_all_occurances_or_remove_whitespaces_if_trim_string_is_null(
            string currentValue, string trimString, string expected)
        {
            // Act
            var actual = currentValue.TrimStart(trimString);

            // Assert
            actual.Should().Be(expected);
        }

        [Theory]
        [AutoData]
        public void Calling_trim_start_on_a_null_should_throw(string trimString)
        {
            // Arrange
            string nullValue = null;

            // Act & Assert
            nullValue.Invoking(x => x.TrimStart(trimString))
                .Should().ThrowExactly<ArgumentNullException>();
        }

        [Theory]
        [InlineData("foo", "FOO", true)]
        [InlineData("Foo", "fOO", true)]
        [InlineData("FOO", "BAR", false)]
        [InlineData("FŪŲ", "fūų", true)]
        [InlineData("BĄR", "bąr", true)]
        [InlineData("1FOO@.", "1foo@.", true)]
        [InlineData("FOO bar", "foo BAR", true)]
        public void Calling_equals_ignore_case_should_return_true_if_only_casing_differs(string left, string right, bool expected)
        {
            // Act & Assert
            left.EqualsIgnoreCase(right).Should().Be(expected);
        }

        [Theory]
        [InlineData("foo", null)]
        [InlineData(null, "bar")]
        public void Calling_equals_ignore_case_with_null_should_throw(string left, string right)
        {
            // Act & Assert
            left.Invoking(x => x.EqualsIgnoreCase(right))
                .Should().Throw<ArgumentNullException>();
        }
    }
}
