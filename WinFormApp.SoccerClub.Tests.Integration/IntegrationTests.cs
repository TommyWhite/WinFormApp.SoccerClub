using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WinFormApp.SoccerClub.Tests.Integration
{
    [TestClass]
    public partial class IntegrationTests
    {
        [TestMethod]
        public void PlayersDBAccessible()
        {
            var connectionString = GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Trace.WriteLine("State: {0}", connection.State.ToString());
            Assert.AreEqual(connection.State, ConnectionState.Open);
            connection.Close();
            Assert.AreEqual(connection.State, ConnectionState.Closed);
        }

    }
}
