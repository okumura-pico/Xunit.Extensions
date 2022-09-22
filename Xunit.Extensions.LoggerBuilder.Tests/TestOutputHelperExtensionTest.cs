using System;

namespace Microsoft.Extensions.Logging;

public class TestOutputHelperExtensionTest
{
    private readonly ITestOutputHelper _output;

    public TestOutputHelperExtensionTest(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void TestCreateLoggerFactory()
    {
        // Given

        // When
        var actual = _output.CreateLoggerFactory();

        // Then
        actual.Should().NotBeNull();
    }

    [Fact]
    public void TestCreateLoggerWithConfiguraion()
    {
        // Given
        var mock = new Mock<Action<ILoggingBuilder>>();

        // When
        var actual = _output.CreateLoggerFactory(mock.Object);

        // Then
        mock.Verify(x => x.Invoke(It.IsAny<ILoggingBuilder>()));
        actual.Should().NotBeNull();
    }
}
