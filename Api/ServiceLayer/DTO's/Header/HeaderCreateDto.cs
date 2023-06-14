using Microsoft.AspNetCore.Http;

namespace ServiceLayer.DTOs.Header
{
    public class HeaderCreateDto
    {
        public IFormFile? Photo { get; set; }
        public string? Title { get; set; }
    }
}
