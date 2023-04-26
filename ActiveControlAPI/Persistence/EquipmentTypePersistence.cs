using System.ComponentModel.DataAnnotations.Schema;

namespace ActiveControlAPI.Persistence
{
    public class EquipmentTypePersistence
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("Model")]
        public string Model { get; set; }
        [Column("Observation")]
        public string? Observation { get; set; }
    }
}
