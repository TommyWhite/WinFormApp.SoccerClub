using System.Configuration;

namespace WinFormApp.SoccerClub.Tests.Integration
{
    public partial class IntegrationTests
    {
        static private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["playersDB"].ToString();
        }
    }
}
