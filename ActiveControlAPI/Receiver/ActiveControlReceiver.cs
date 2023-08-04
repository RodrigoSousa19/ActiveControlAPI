using ActiveControlAPI.Models;
using ActiveControlAPI.Persistence;
using ActiveControlAPI.Repository;
using ActiveControlAPI.Uow;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Reflection.Metadata;

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

        public List<CompanyAssetsPersistence> GetAllCompanyAssets()
        {
            using(SqlConnection connection = _dbFactory.GetConnection())
            {
                connection.Open();

                try
                {
                    return _repository.GetAllCompanyAssets(connection);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public List<CostCenterPersistence> GetAllCostCenter()
        {
            using (SqlConnection connection = _dbFactory.GetConnection())
            {
                connection.Open();

                try
                {
                    return _repository.GetAllCostCenter(connection);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public List<EquipmentPersistence> GetAllEquipments()
        {
            using (SqlConnection connection = _dbFactory.GetConnection())
            {
                connection.Open();

                try
                {
                    return _repository.GetAllEquipments(connection);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
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
                finally
                {
                    connection.Close();
                }
            }
        }

        public List<RenterPersistence> GetAllRenters()
        {
            using (SqlConnection connection = _dbFactory.GetConnection())
            {
                connection.Open();

                try
                {
                    return _repository.GetAllRenters(connection);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public List<UsersPersitence> GetAllUsers()
        {
            using (SqlConnection connection = _dbFactory.GetConnection())
            {
                connection.Open();

                try
                {
                    return _repository.GetAllUsers(connection);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public List<UserTypePersistence> GetAllUserTypes()
        {
            using (SqlConnection connection = _dbFactory.GetConnection())
            {
                connection.Open();

                try
                {
                    return _repository.GetAllUserTypes(connection);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public bool RegisterNewRenter(Renter payload, out string message)
        {
            message = "";
            using(SqlConnection connection = _dbFactory.GetConnection())
            {
                connection.Open();

                try
                {
                    if(_repository.RegisterNewRenter(connection, payload)) ;
                    {
                        message = "Fornecedor cadastrado com sucesso";
                        return true;
                    }

                }
                catch (Exception ex)
                {
                    message = $"Erro ao cadastrar novo fornecedor: {ex.Message}";
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
