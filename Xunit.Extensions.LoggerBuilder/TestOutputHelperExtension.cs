using System;

using Xunit.Abstractions;

namespace Microsoft.Extensions.Logging
{
    public static class TestOutputHelperExtension
    {
        /// <summary>
        /// Create LoggerFactory
        /// </summary>
        /// <param name="output"></param>
        /// <returns></returns>
        public static ILoggerFactory CreateLoggerFactory(this ITestOutputHelper output) =>
            CreateLoggerFactory(output, builder => { });

        /// <summary>
        /// Create LoggerFactory
        /// </summary>
        /// <param name="output"></param>
        /// <param name="configure"></param>
        /// <returns></returns>
        public static ILoggerFactory CreateLoggerFactory(this ITestOutputHelper output,
                                                         Action<ILoggingBuilder> configure) =>
            LoggerFactory.Create(builder =>
            {
                configure.Invoke(builder);
                builder.AddProvider(new XunitLoggerProvider(output));
            });
    }
}
