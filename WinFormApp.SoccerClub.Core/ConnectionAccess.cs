namespace WinFormApp.SoccerClub.Core
{
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
            //TODO: Add functionality. 'Resolving connection string from the .config file.'
            //ConnectionString = ConfigurationManager
            //    .ConnectionStrings[connectionStringName].ConnectionString;
            ConnectionString = @"Data Source=(localdb)\v11.0;Initial Catalog=players;Integrated Security = SSPI; Connect Timeout = 10; Trusted_Connection = Yes;";
        }
    }
}
