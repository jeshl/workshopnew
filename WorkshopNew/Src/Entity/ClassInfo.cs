using System.ComponentModel.DataAnnotations;

namespace WorkshopNew.Src.Entity
{
    public class ClassInfo
    {
        [Key]
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
