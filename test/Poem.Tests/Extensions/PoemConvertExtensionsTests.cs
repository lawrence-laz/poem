namespace Poem.Tests.Extensions;

public class PoemConvertExtensionsTests
{
    [Theory, AutoData]
    public void Calling_ToBase64String_returns_same_result_as_standard_method(byte[] bytes)
    {
        // Arrange
        var expected = Convert.ToBase64String(bytes);

        // Act
        var actual = bytes.ToBase64String();

        // Assert
        actual.Should().Be(expected);
    }
}
