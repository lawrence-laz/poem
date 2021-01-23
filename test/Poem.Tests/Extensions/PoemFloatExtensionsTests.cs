using AutoFixture.Xunit2;
using FluentAssertions;
using System;
using System.Globalization;
using Xunit;

namespace Poem.Tests.Extensions
{
    public class PoemFloatExtensionsTests
    {
        private IFormatProvider _formatProvider = new CultureInfo("en-US");
        private NumberStyles _numberStyles = NumberStyles.AllowDecimalPoint;

        [Theory, AutoData]
        public void Calling_parse_with_format_provider_should_return_same_result_as_standard_method(float expected)
        {
            // Arrange
            var numberString = expected.ToString(_formatProvider);

            // Act
            var actual = numberString.ParseFloat(_formatProvider);

            // Assert
            actual.Should().Be(expected);
        }

        [Theory, AutoData]
        public void Calling_parse_with_number_styles_should_return_same_result_as_standard_method(float expected)
        {
            // Arrange
            var numberString = expected.ToString();

            // Act
            var actual = numberString.ParseFloat(_numberStyles);

            // Assert
            actual.Should().Be(expected);
        }

        [Theory, AutoData]
        public void Calling_parse_with_number_styles_and_format_provider_should_return_same_result_as_standard_method(float expected)
        {
            // Arrange
            var numberString = expected.ToString(_formatProvider);

            // Act
            var actual = numberString.ParseFloat(_numberStyles, _formatProvider);

            // Assert
            actual.Should().Be(expected);
        }

        [Theory, AutoData]
        public void Calling_parse_should_return_same_result_as_standard_method(float expected)
        {
            // Arrange
            var numberString = expected.ToString();

            // Act
            var actual = numberString.ParseFloat();

            // Assert
            actual.Should().Be(expected);
        }
    }
}
