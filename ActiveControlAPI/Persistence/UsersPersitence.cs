using System.ComponentModel.DataAnnotations.Schema;

namespace ActiveControlAPI.Persistence
{
    public class UsersPersitence
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("User")]
        public string User { get; set; }
        [Column("UserName")]
        public string UserName { get; set; }
        [Column("UserTypeId")]
        public int UserTypeId { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("CostCenterId")]
        public int CostCenterid { get; set; }
    }
}
