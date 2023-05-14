using DomainLayer.Common;

namespace DomainLayer.Entities
{
    public class Banner : BaseEntity
    {
        public byte[]? Image { get; set; }
        public string? Title { get; set; }
    }
}
