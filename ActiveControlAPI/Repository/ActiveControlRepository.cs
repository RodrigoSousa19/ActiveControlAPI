using ActiveControlAPI.Models;
using ActiveControlAPI.Persistence;
using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace ActiveControlAPI.Repository
{
    public class ActiveControlRepository : IActiveControlRepository
    {
        public List<CompanyAssetsPersistence> GetAllCompanyAssets(SqlConnection connection)
        {
            string query = "";

            query += Environment.NewLine + "Select";
            query += Environment.NewLine + "    Id";
            query += Environment.NewLine + "    ,EquipmentId";
            query += Environment.NewLine + "    ,UserId";
            query += Environment.NewLine + "    ,DeliveryDate";
            query += Environment.NewLine + "    ,ReturnDate";
            query += Environment.NewLine + "From";
            query += Environment.NewLine + "    CompanyAssets WITH(NOLOCK)";

           return connection.Query<CompanyAssetsPersistence>(query).ToList();
        }

        public List<CostCenterPersistence> GetAllCostCenter(SqlConnection connection)
        {
            string query = "";

            query += Environment.NewLine + "Select";
            query += Environment.NewLine + "    Id";
            query += Environment.NewLine + "    ,CostCenter";
            query += Environment.NewLine + "    ,Description";
            query += Environment.NewLine + "From";
            query += Environment.NewLine + "    CostCenter WITH(NOLOCK)";

            return connection.Query<CostCenterPersistence>(query).ToList();
        }

        public List<EquipmentPersistence> GetAllEquipments(SqlConnection connection)
        {
            string query = "";
            query += Environment.NewLine + "SELECT";
            query += Environment.NewLine + "    Id";
            query += Environment.NewLine + "    ,EquipmentId";
            query += Environment.NewLine + "    ,ServiceTag";
            query += Environment.NewLine + "    ,RenterId";
            query += Environment.NewLine + "    ,RentValue";
            query += Environment.NewLine + "FROM";
            query += Environment.NewLine + "    Equipment WITH(NOLOCK)";
            query += Environment.NewLine + "WHERE";
            query += Environment.NewLine + "    CancelDate IS NULL";

            return connection.Query<EquipmentPersistence>(query).ToList();
        }

        public List<EquipmentTypePersistence> GetAllEquipmentType(SqlConnection connection)
        {
            string query = "";

            query += Environment.NewLine + "Select";
            query += Environment.NewLine + "    Id";
            query += Environment.NewLine + "    ,Name";
            query += Environment.NewLine + "    ,Model";
            query += Environment.NewLine + "    ,Observation";
            query += Environment.NewLine + "From";
            query += Environment.NewLine + "    EquipmentType WITH(NOLOCK)";

            return connection.Query<EquipmentTypePersistence>(query).ToList();
        }

        public List<RenterPersistence> GetAllRenters(SqlConnection connection)
        {
            string query = "";
            query += Environment.NewLine + "SELECT";
            query += Environment.NewLine + "    Id";
            query += Environment.NewLine + "    ,Name";
            query += Environment.NewLine + "    ,ContractDate";
            query += Environment.NewLine + "FROM";
            query += Environment.NewLine + "    Renter WITH(NOLOCK)";
            query += Environment.NewLine + "WHERE";
            query += Environment.NewLine + "    CancelDate IS NULL";

            return connection.Query<RenterPersistence>(query).ToList();
        }

        public List<UsersPersitence> GetAllUsers(SqlConnection connection)
        {
            string query = "";
            query += Environment.NewLine + "SELECT";
            query += Environment.NewLine + "    Id";
            query += Environment.NewLine + "    ,[User]";
            query += Environment.NewLine + "    ,UserName";
            query += Environment.NewLine + "    ,UserTypeId";
            query += Environment.NewLine + "    ,Email";
            query += Environment.NewLine + "    ,CostCenterId";
            query += Environment.NewLine + "FROM";
            query += Environment.NewLine + "    Users WITH(NOLOCK)";

            return connection.Query<UsersPersitence>(query).ToList();
        }

        public List<UserTypePersistence> GetAllUserTypes(SqlConnection connection)
        {
            string query = "";
            query += Environment.NewLine + "SELECT";
            query += Environment.NewLine + "    Id";
            query += Environment.NewLine + "    ,Type";
            query += Environment.NewLine + "    ,Description";
            query += Environment.NewLine + "FROM";
            query += Environment.NewLine + "    UsersType WITH(NOLOCK)";

            return connection.Query<UserTypePersistence>(query).ToList();
        }

        public bool RegisterNewRenter(SqlConnection connection, Renter payload)
        {
            string query = "";

            query += Environment.NewLine + "INSERT INTO[dbo].[Renter]";
            query += Environment.NewLine + "    ([Name]";
            query += Environment.NewLine + "    ,[Email]";
            query += Environment.NewLine + "    ,[ContractDate]";
            query += Environment.NewLine + "    ,[Status])";
            query += Environment.NewLine + "VALUES";
            query += Environment.NewLine + "    (@Name";
            query += Environment.NewLine + "    ,@Email";
            query += Environment.NewLine + "    ,@ContractDate";
            query += Environment.NewLine + "    ,@Status)";

            var insertedRows = connection.Execute(query, payload);

            return insertedRows > 0;
        }
    }
}
