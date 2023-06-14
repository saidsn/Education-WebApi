using Microsoft.AspNetCore.Http;

namespace ServiceLayer.DTO_s.Service
{
    public class ServiceCreateDto
    {
        public IFormFile? Photo { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
