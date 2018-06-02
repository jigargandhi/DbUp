using DbUp.Builder;

namespace DbUp.Engine
{
    /// <summary>
    /// Engine that logs application version
    /// </summary>
    public class ApplicationUpgradeEngine
    {
        private readonly ApplicationConfiguration configuration;

        public ApplicationUpgradeEngine(ApplicationConfiguration configuration)
        {
            this.configuration = configuration;
        }

        /// <summary>
        /// Log current application version, node name with current timestamp to database
        /// </summary>
        public void PerformLog()
        {
            //TODO: Perform logging

        }
        
    }
}
