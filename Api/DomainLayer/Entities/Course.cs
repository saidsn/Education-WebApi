using DomainLayer.Common;

namespace DomainLayer.Entities
{
    public class Course : BaseEntity
    {
        public byte[]? Image { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public List<Student>? Students { get; set; }
        public List<CourseAuthor>? CourseAuthors { get; set; }
    }
}
