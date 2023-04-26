using Microsoft.AspNetCore.Mvc;
using ActiveControlAPI.Receiver;
using ActiveControlAPI.Persistence;

namespace ActiveControlAPI.Controllers
{
    [ApiController]
    [Route("[controller]/api")]
    public class ActiveControlController : ControllerBase
    {
        

        private readonly ILogger<ActiveControlController> _logger;
        private readonly IActiveControlReceiver _Receiver; 

        public ActiveControlController(ILogger<ActiveControlController> logger, IActiveControlReceiver receiver)
        {
            _logger = logger;
            _Receiver = receiver;
        }

        [HttpGet("GetAllCompanyAssets")]
        public List<CompanyAssetsPersistence> GetAllCompanyAssets()
        {
            return _Receiver.GetAllCompanyAssets();
        }

        [HttpGet("GetAllCostCenter")]
        public List<CostCenterPersistence> GetAllCostCenter()
        {
            return _Receiver.GetAllCostCenter();
        }

        [HttpGet("GetAllEquipmentTypes")]
        public List<EquipmentTypePersistence> GetAllEquipmentTypes()
        {
            return _Receiver.GetAllEquipmentType();
        }

        [HttpGet("GetAllEquipments")]
        public List<EquipmentPersistence> GetAllEquipments()
        {
            return _Receiver.GetAllEquipments();
        }

        [HttpGet("GetAllRenters")]
        public List<RenterPersistence> GetAllRenters()
        {
            return _Receiver.GetAllRenters();
        }

        [HttpGet("GetAllUsers")]
        public List<UsersPersitence> GetAllUsers()
        {
            return _Receiver.GetAllUsers();
        }

        [HttpGet("GetAllUserTypes")]
        public List<UserTypePersistence> GetAllUserTypes()
        {
            return _Receiver.GetAllUserTypes();
        }
    }
}