using System.ComponentModel.DataAnnotations.Schema;

namespace ActiveControlAPI.Persistence
{
    public class UsersPersitence
    {
        [Column("UserName")]
        public string UserName { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("CostCenter")]
        public int CostCenter { get; set; }
        [Column("Description")]
        public string Description { get; set; }
    }
}
