using ActiveControlAPI.Models;
using ActiveControlAPI.Persistence;
using System.Data.SqlClient;

namespace ActiveControlAPI.Repository
{
    public interface IActiveControlRepository
    {
        List<CompanyAssetsPersistence> GetAllCompanyAssets(SqlConnection connection);
        List<CostCenterPersistence> GetAllCostCenter(SqlConnection connection);
        List<EquipmentPersistence> GetAllEquipments(SqlConnection connection);
        List<EquipmentTypePersistence> GetAllEquipmentType(SqlConnection connection);
        List<RenterPersistence> GetAllRenters(SqlConnection connection);
        List<UsersPersitence> GetAllUsers(SqlConnection connection);
        List<UserTypePersistence> GetAllUserTypes(SqlConnection connection);
        bool RegisterNewRenter(SqlConnection connection, Renter payload);
    }
}
