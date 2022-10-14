# Xunit.Extensions.TestOutputHelper

Building logger extension for Xunit ITesOutputHelper.

## Usage

```cs
using Microsoft.Extensions.Logging;

public class AwesomeTest
{
    private readonly ILogger<TestTarget> _logger;

    // Add ITestOutputHelper to constructor parameter
    public AwesomeTest(ITestOutputHelper output)
    {
        // Create logger with default configuration
        _logger = output
            .CreateLoggerFactory()
            .CreateLogger<TestTarget>();

        // or...

        // Create logger with some configuration
        _logger = output
            .CrateLoggerFactory(builder => {
                builder.SetMinimumLevel(LogLevel.Debug)
            })
            .CreateLogger<TestTarget>();
    }
}
```

