using DbUp.Engine.Transactions;
using System;

namespace DbUp.Builder
{
    public class ApplicationConfiguration
    {
        /// <summary>
        /// Name of the node where the application is deployed
        /// </summary>
        public string NodeName { get; set; }

        /// <summary>
        /// Application version that is logged to database
        /// </summary>
        public string ApplicationVersion { get; set; }

        public IConnectionManager ConnectionManager { get; set; }

        public void Validate()
        {
            if (string.IsNullOrEmpty(NodeName)) throw new ArgumentException("A node name is required.");
            if (string.IsNullOrEmpty(ApplicationVersion)) throw new ArgumentException("An application version is required.");
            if (ConnectionManager==null) throw new ArgumentException("A connection manager is required.");
        }
    }
}
