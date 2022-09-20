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
        _logger = output.CreateLogger<TestTarget>();

        // Or specify mimum log level
        _logger = output.CreateLogger<TestTarget>(LogLevel.Debug);
    }
}
```

