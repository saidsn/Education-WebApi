using Microsoft.AspNetCore.Http;

namespace ServiceLayer.DTOs.Header
{
    public class HeaderUpdateDto
    {
        public IFormFile? Photo { get; set; }
        public string? Title { get; set; }
    }
}
