using System;

using Xunit.Abstractions;

namespace Microsoft.Extensions.Logging
{
    public class XunitLogger : ILogger
    {
        private readonly string _categoryName;
        private readonly ITestOutputHelper _output;

        public XunitLogger(string categoryName, ITestOutputHelper output)
        {
            _categoryName = categoryName;
            _output = output;
        }

        public IDisposable BeginScope<TState>(TState state) => null;

        public bool IsEnabled(LogLevel logLevel) => true;

        public void Log<TState>(
            LogLevel logLevel,
            EventId eventId,
            TState state,
            Exception exception,
            Func<TState, Exception, string> formatter)
        {
            _output.WriteLine($"{logLevel}: {_categoryName} {eventId} {formatter(state, exception)}");
        }
    }
}