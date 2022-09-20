using System.Collections.Generic;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;

namespace Xunit.Configuration
{
    /// <summary>
    /// Load configuration from settings.json
    /// </summary>
    public class SettingsJsonFixture : IConfiguration
    {
        private readonly IConfigurationRoot _configurationRoot;

        public SettingsJsonFixture()
        {
            _configurationRoot = new ConfigurationBuilder()
                .AddJsonFile("testsettings.json")
                .Build();
        }

        public string this[string key]
        {
            get => _configurationRoot[key];
            set => _configurationRoot[key] = value;
        }

        public IEnumerable<IConfigurationSection> GetChildren()
            => _configurationRoot.GetChildren();


        public IChangeToken GetReloadToken()
            => _configurationRoot.GetReloadToken();

        public IConfigurationSection GetSection(string key)
            => _configurationRoot.GetSection(key);
    }
}