using System.ComponentModel.DataAnnotations.Schema;

namespace ActiveControlAPI.Persistence
{
    public class UserTypePersistence
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("Type")]
        public string Type { get; set; }
        [Column("Description")]
        public string? Description { get; set; }
    }
}
