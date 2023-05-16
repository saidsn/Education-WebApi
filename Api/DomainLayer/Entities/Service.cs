using DomainLayer.Common;

namespace DomainLayer.Entities
{
    public class Service : BaseEntity
    {
        public byte[]? Image { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
