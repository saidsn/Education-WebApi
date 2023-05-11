using DomainLayer.Common;


namespace DomainLayer.Entities
{
    public class Header : BaseEntity
    {
        public byte[]? Image { get; set; }
        public string? Title { get; set; }
    }
}
