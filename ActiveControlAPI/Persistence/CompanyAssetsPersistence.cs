using System.ComponentModel.DataAnnotations.Schema;

namespace ActiveControlAPI.Persistence
{
    public class CompanyAssetsPersistence
    {
        [Column("Id")]
        public long Id { get; set; }
        [Column("EquipmentId")]
        public long EquipmentId { get; set; }
        [Column("UserId")]
        public long UserId { get; set; }
        [Column("DeliveryDate")]
        public DateTime DeliveryDate { get; set; }
        [Column("ReturnDate")]
        public DateTime? ReturnDate { get; set; }
    }
}
