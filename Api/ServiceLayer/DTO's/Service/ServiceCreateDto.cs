namespace ServiceLayer.DTO_s.Service
{
    public class ServiceCreateDto
    {
        public byte[]? Image { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
