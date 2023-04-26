using ActiveControlAPI.Persistence;
using System.Data.SqlClient;

namespace ActiveControlAPI.Receiver
{
    public interface IActiveControlReceiver
    {
        List<CompanyAssetsPersistence> GetAllCompanyAssets();
        List<CostCenterPersistence> GetAllCostCenter();
        List<EquipmentPersistence> GetAllEquipments();
        List<EquipmentTypePersistence> GetAllEquipmentType();
        List<RenterPersistence> GetAllRenters();
        List<UsersPersitence> GetAllUsers();
        List<UserTypePersistence> GetAllUserTypes();
    }
}
