using DomainLayer.Common;

namespace DomainLayer.Entities
{
    public class Author : BaseEntity
    {
        public string? Name { get; set; }
        public byte[]? Image { get; set; }
        public string? Position { get; set; }
        public ICollection<CourseAuthor>? CourseAuthors { get; set; }
    }
}
