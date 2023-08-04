using System.ComponentModel.DataAnnotations.Schema;

namespace ActiveControlAPI.Persistence
{
    public class RenterPersistence
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("ContractDate")]
        public DateTime ContractDate { get; set; }
        [Column("Status")]
        public bool Status { get; set; }
        [Column("Email")]
        public string Email { get; set; }
    }
}
