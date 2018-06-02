using DbUp.Builder;

namespace DbUp
{
    /// <summary>
    /// A fluent builder to log application version 
    /// </summary>
    public static class LogApplicationVersion
    {
        private static readonly SupportedDatabaseForLog Instance = new SupportedDatabaseForLog();

        /// <summary>
        /// Returns the databases supported by DbUp.
        /// </summary>
        public static SupportedDatabaseForLog To
        {
            get { return Instance; }
        }
    }
}
