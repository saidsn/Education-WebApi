using DomainLayer.Common;

namespace DomainLayer.Entities
{
    public class About : BaseEntity
    {
        public byte[]? Image { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
