using System;

using Xunit.Abstractions;

namespace Microsoft.Extensions.Logging
{
    public static class TestOutputHelperExtension
    {
        /// <summary>
        /// Create Logger
        /// </summary>
        /// <param name="output"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static ILogger<T> CreateLogger<T>(this ITestOutputHelper output) =>
            CreateLoggerFactory(output).CreateLogger<T>();

        /// <summary>
        /// Create Logger
        /// </summary>
        /// <param name="output"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static ILogger CreateLogger(this ITestOutputHelper output, Type type) =>
            CreateLogger(output, type.Name);

        /// <summary>
        /// Create Logger
        /// </summary>
        /// <param name="output"></param>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        public static ILogger CreateLogger(this ITestOutputHelper output, string categoryName) =>
            CreateLoggerFactory(output).CreateLogger(categoryName);

        private static ILoggerFactory CreateLoggerFactory(ITestOutputHelper output) =>
            LoggerFactory.Create(builder =>
            {
                builder.AddProvider(new XunitLoggerProvider(output));
            });
    }
}
