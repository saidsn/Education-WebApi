using Microsoft.AspNetCore.Http;

namespace ServiceLayer.DTOs.about
{
    public class AboutUpdateDto
    {
        public IFormFile? Photo { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
