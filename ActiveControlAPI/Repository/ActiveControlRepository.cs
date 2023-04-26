using ActiveControlAPI.Persistence;
using Dapper;
using System.Data.SqlClient;

namespace ActiveControlAPI.Repository
{
    public class ActiveControlRepository : IActiveControlRepository
    {
        public List<EquipmentTypePersistence> GetAllEquipmentType(SqlConnection connection)
        {
            string query = "";

            query += Environment.NewLine + "Select";
            query += Environment.NewLine + "    Id";
            query += Environment.NewLine + "    ,Name";
            query += Environment.NewLine + "    ,Model";
            query += Environment.NewLine + "    ,Observation";
            query += Environment.NewLine + "from";
            query += Environment.NewLine + "    EquipmentType";

            var equipmentDeliveries = connection.Query<EquipmentTypePersistence>(query).ToList();

            return equipmentDeliveries;
        }
    }
}
