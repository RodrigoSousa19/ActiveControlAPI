using System.ComponentModel.DataAnnotations.Schema;

namespace ActiveControlAPI.Persistence
{
    public class CostCenterPersistence
    {
        [Column("Id")]
        public long Id { get; set; }
        [Column("CostCenter")]
        public string CostCenter { get; set; }
        [Column("Description")]
        public string Description { get; set; }
    }
}
