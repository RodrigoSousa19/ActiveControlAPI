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

        [HttpGet("GetAllEquipmentTypes")]
        public List<EquipmentTypePersistence> GetAllEquipmentTypes()
        {
            return _Receiver.GetAllEquipmentType();
        }
    }
}