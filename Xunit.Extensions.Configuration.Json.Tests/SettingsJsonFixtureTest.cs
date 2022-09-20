namespace Xunit.Configuration;

public class SettingsJsonFixtureTest
{
    [Fact]
    public void TestCreateInstance()
    {
        // Given

        // When
        var instance = new SettingsJsonFixture();

        // Then
        instance.Should().BeOfType<SettingsJsonFixture>();
    }

    [Fact]
    public void TestGetSettingByKey()
    {
        // Given
        var instance = new SettingsJsonFixture();

        // When
        var actual1 = instance["hello"];
        var actual2 = instance["This:is:test"];

        // Then
        actual1.Should().Be("test");
        actual2.Should().Be("fixture");
    }

    [Fact]
    public void TestGetSecion()
    {
        // Given
        var instance = new SettingsJsonFixture();
    
        // When
        var actual = instance.GetSection("This");

        // Then
        actual.Should().NotBeNull();
    }

    [Fact]
    public void TestGetChildren()
    {
        // Given
        var instance = new SettingsJsonFixture();
    
        // When
        var actual = instance.GetChildren();
    
        // Then
        actual.Should().HaveCount(2);
    }
}
