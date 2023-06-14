using Microsoft.AspNetCore.Http;

namespace ServiceLayer.DTOs.Slider
{
    public class SliderUpdateDto
    {
        public IFormFile? Photo { get; set; }
        public string? Title { get; set; }
    }
}
