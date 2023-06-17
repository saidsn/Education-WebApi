using Microsoft.AspNetCore.Http;

namespace ServiceLayer.DTO_s.Course
{
    public class CourseUpdateDto
    {
        public IFormFile? Photo { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        //public List<int>? StudentIds { get; set; }
        public List<int>? AuthorIds { get; set; }
    }
}
