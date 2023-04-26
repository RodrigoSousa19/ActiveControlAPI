using System.Data.SqlClient;

namespace ActiveControlAPI.Uow
{
    public interface IDbFactory
    {
        public SqlConnection GetConnection();
    }
}
