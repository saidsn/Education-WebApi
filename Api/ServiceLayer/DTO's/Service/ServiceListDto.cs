namespace ServiceLayer.DTO_s.Service
{
    public class ServiceListDto
    {
        public int Id { get; set; }
        public string? Image { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
