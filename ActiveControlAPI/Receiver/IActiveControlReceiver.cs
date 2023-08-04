using ActiveControlAPI.Models;
using ActiveControlAPI.Persistence;
using Microsoft.AspNetCore.Mvc;
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
        bool RegisterNewRenter(Renter payload, out string message);
    }
}
