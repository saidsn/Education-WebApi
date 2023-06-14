using Microsoft.AspNetCore.Http;

namespace ServiceLayer.DTO_s.Student
{
    public class StudentCreateDto
    {
        public IFormFile? Photo { get; set; }
        public string? FullName { get; set; }
        public int Age { get; set; }
        public string? Info { get; set; }
        public int CourseId { get; set; }
    }
}
