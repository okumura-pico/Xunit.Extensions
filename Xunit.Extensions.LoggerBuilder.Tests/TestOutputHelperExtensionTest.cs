namespace Microsoft.Extensions.Logging;

public class TestOutputHelperExtensionTest
{
    private readonly ITestOutputHelper _output;

    public TestOutputHelperExtensionTest(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void TestCreateGenericLogger()
    {
        // Given

        // When
        var actual = _output.CreateLogger<TestOutputHelperExtensionTest>();

        // Then
        actual.Should().BeOfType<Logger<TestOutputHelperExtensionTest>>();
    }

    [Fact]
    public void TestCreateLoggerByType()
    {
        // Given

        // When
        var actual = _output.CreateLogger(typeof(TestOutputHelperExtensionTest));

        // Then
        actual.Should().NotBeNull();
    }

    [Fact]
    public void TestCreateLoggerByName()
    {
        // Given
        var categoryName = this.GetType().Name;

        // When
        var actual = _output.CreateLogger(categoryName);

        // Then
        actual.Should().NotBeNull();
    }
}