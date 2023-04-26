using System.ComponentModel.DataAnnotations.Schema;

namespace ActiveControlAPI.Persistence
{
    public class EquipmentPersistence
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("EquipmentId")]
        public int EquipmentId { get; set; }
        [Column("ServiceTag")]
        public String ServiceTag { get; set; }
        [Column("RenterId")]
        public long RenterId { get; set; }
        [Column("RentValue")]
        public double RentValue { get; set; }
        [Column("CancelDate")]
        public DateTime? CancelDate { get; set; }
    }
}
