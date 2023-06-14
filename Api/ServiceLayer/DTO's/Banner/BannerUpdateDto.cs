using Microsoft.AspNetCore.Http;

namespace ServiceLayer.DTO_s.Banner
{
    public class BannerUpdateDto
    {
        public IFormFile? Photo { get; set; }
        public string? Title { get; set; }
    }
}
