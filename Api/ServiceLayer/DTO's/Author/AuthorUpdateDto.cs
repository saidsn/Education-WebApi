using Microsoft.AspNetCore.Http;

namespace ServiceLayer.DTO_s.Author
{
    public class AuthorUpdateDto
    {
        public IFormFile? Photo { get; set; }
        public string? Name { get; set; }
        public string? Position { get; set; }
        public List<int>? CourseIds { get; set; }
    }
}
