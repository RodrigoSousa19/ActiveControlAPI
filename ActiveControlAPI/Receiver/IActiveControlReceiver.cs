using ActiveControlAPI.Persistence;

namespace ActiveControlAPI.Receiver
{
    public interface IActiveControlReceiver
    {
        public List<EquipmentTypePersistence> GetAllEquipmentType();
    }
}
