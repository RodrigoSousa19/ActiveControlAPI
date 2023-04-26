using System.Data.SqlClient;

namespace ActiveControlAPI.Uow
{
    public class DbFactory : IDbFactory
    {
        private readonly string connectionString;
        public DbFactory(IConfiguration configuration)
        {
            this.connectionString = configuration.GetValue<string>("Connection");
        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(this.connectionString);
        }
    }
}
