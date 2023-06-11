using DomainLayer.Entities;

namespace ServiceLayer.DTO_s.Course
{
    public class CourseDto
    {
        public byte[]? Image { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public List<DomainLayer.Entities.Student>? Students { get; set; }
        public List<CourseAuthor>? CourseAuthors { get; set; }
    }
}
