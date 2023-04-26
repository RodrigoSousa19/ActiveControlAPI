using ActiveControlAPI.Persistence;
using System.Data.SqlClient;

namespace ActiveControlAPI.Repository
{
    public interface IActiveControlRepository
    {
        public List<EquipmentTypePersistence> GetAllEquipmentType(SqlConnection connection);
    }
}
