# Xunit.Extensions.LoggerBuilder

Build logger with XUnit ITestOutputHelper.

## Usage

```cs
using Microsoft.Extensions.Logging;

public class AwesomeTest
{
    private readonly ILogger<TestTarget> _logger;

    // Add ITestOutputHelper to constructor parameter
    public AwesomeTest(ITestOutputHelper output)
    {
        // Create logger
        _logger = output
            .CreateLoggerFactory()
            .CreateLogger<TestTarget>();

        // Create logger with configuration
        _logger = output
            .CrateLoggerFactory(builder => {
                builder.SetMinimumLevel(LogLevel.Debug)
            })
            .CreateLogger<TestTarget>();
    }
}
```

