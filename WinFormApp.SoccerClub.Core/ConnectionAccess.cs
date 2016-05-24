namespace WinFormApp.SoccerClub.Core
{
    using System;
    using System.Configuration;

    /// <summary>
    /// Provides connection string to the database.
    /// </summary>
    public abstract class ConnectionAccess
    {
        /// <summary>
        /// Connection string of the particular database.
        /// </summary>
        protected string ConnectionString { get; private set; }

        /// <summary>
        /// Creates instance of the <typeparamref name="ConnectionAccess"/> 
        /// retrieving connection string by connection name from config file. 
        /// </summary>
        /// <param name="connectionStringName">Connection string name.</param>
        protected ConnectionAccess(string connectionStringName)
        {
            ConnectionString = ConfigurationManager
                .ConnectionStrings[connectionStringName].ConnectionString;
        }
    }
}