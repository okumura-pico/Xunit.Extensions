# Xunit.Extensions.Configuration.Json

Load configuration from "testsettings.json" file.

## Usage

1. Create "testsettiongs.json" file at the top directory of a test project.

```json
{
  "this": "is just a sample",
  "hello": "test"
}
```

2. Add following section to the .csproj file of a test project.

```xml
  <ItemGroup>
    <Content Include="testsettings.json" CopyToOutputDirectory="PreserveNewest" />
  </ItemGroup>
```

3. Modify your test to use `SettingsJsonFixutre`.

```cs
public class YourTess : IClassFixture<SettingsJsonFixture>
{
    private readonly SettingsJsonFixture _settings;

    public YourTests(SettingsJsonFixture settings)
    {
        _settings = settings;
    }

    [fact]
    public void TestOne()
    {
        // Use it as you like.
        var data = _settings["data"];
    }
}
```
