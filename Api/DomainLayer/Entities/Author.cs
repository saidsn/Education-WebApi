using DomainLayer.Common;

namespace DomainLayer.Entities
{
    public class Author : BaseEntity
    {
        public byte[]? Image { get; set; }
        public string? Name { get; set; }
        public string? Position { get; set; }
        public List<CourseAuthor>? CourseAuthors { get; set; }
    }
}
