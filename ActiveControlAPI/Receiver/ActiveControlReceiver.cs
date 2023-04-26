using ActiveControlAPI.Persistence;
using ActiveControlAPI.Repository;
using ActiveControlAPI.Uow;
using System.Data.SqlClient;

namespace ActiveControlAPI.Receiver
{
    public class ActiveControlReceiver : IActiveControlReceiver
    {
        private readonly IActiveControlRepository _repository;
        private readonly IDbFactory _dbFactory;
        private ActiveControlRepository repository = new ActiveControlRepository();

        public ActiveControlReceiver(IActiveControlRepository repository, IDbFactory dbFactory)
        {
            _repository = repository;
            _dbFactory = dbFactory;
        }

        public List<EquipmentTypePersistence> GetAllEquipmentType()
        {
            using (SqlConnection connection = _dbFactory.GetConnection())
            {
                connection.Open();

                try
                {
                    return _repository.GetAllEquipmentType(connection);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
