using DbUp.Engine;
using System;
using System.Collections.Generic;

namespace DbUp.Builder
{
    public class LogApplicationUpgradeBuilder
    {
        private readonly List<Action<ApplicationConfiguration>> callbacks = new List<Action<ApplicationConfiguration>>();

        public void Configure(Action<ApplicationConfiguration> configuration)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }
            callbacks.Add(configuration);
        }


        public ApplicationUpgradeEngine Build()
        {
            var config = new ApplicationConfiguration();
            foreach (var callback in callbacks)
            {
                callback(config);
            }

            config.Validate();
            return new ApplicationUpgradeEngine(config);
        }
    }
}
