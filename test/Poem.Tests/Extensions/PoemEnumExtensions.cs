namespace Poem.Tests.Extensions;

public class PoemEnumExtensions
{
    public enum TestEnum
    {
        Foo,
        Bar
    }

    [Theory, AutoData]
    public void Calling_parse_enum_with_string_returns_same_result_as_standard_method(TestEnum expected)
    {
        // Arrange
        var enumString = expected.ToString();

        // Act
        var actual = enumString.ParseEnum(typeof(TestEnum));

        // Assert
        actual.Should().Be(expected);
        actual.Should().Be(Enum.Parse(typeof(TestEnum), enumString));
    }

    [Theory, AutoData]
    public void Calling_parse_enum_with_type_and_string_returns_same_result_as_standard_method(TestEnum expected)
    {
        // Arrange
        var enumString = expected.ToString();

        // Act
        var actual = enumString.ParseEnum<TestEnum>();

        // Assert
        actual.Should().Be(expected);
        actual.Should().Be(Enum.Parse(typeof(TestEnum), enumString));
    }
}
