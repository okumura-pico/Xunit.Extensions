using Xunit.Abstractions;

namespace Microsoft.Extensions.Logging
{
    public class XunitLoggerProvider : ILoggerProvider
    {
        private readonly ITestOutputHelper _output;

        /// <summary>
        /// cTor
        /// </summary>
        /// <param name="output"></param>
        public XunitLoggerProvider(ITestOutputHelper output)
        {
            _output = output;
        }

        /// <summary>
        /// Create XunitLogger
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        public ILogger CreateLogger(string categoryName)
            => new XunitLogger(categoryName, _output);

        public void Dispose()
        {
            /* Do Nothing */
        }
    }
}