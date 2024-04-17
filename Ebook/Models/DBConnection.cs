using System.Data.SqlClient;

namespace Ebook.Models
{
    public static class DbConnection
    {
        private static readonly string DbConnnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=aspnet-dash-20220301113958;Integrated Security=True;
Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static SqlConnection GetConnection()
        {   
            return new SqlConnection(DbConnnectionString);
        }
    }
}
