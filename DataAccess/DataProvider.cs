using System.Configuration;

namespace DataAccess
{
    public class DataProvider
    {
        public class ConnectionAPI : Connection.Connection
        {
            public ConnectionAPI()
                : base(ConfigurationManager.ConnectionStrings["API"].ConnectionString)
            {
            }
        }
    }
}