using DomainLayer.Common;

namespace DomainLayer.Entities
{
    public class Contact : BaseEntity
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Message { get; set; }
    }
}
