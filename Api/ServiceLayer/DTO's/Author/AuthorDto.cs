using DomainLayer.Entities;

namespace ServiceLayer.DTO_s.Author
{
    public class AuthorDto
    {
        public byte[]? Image { get; set; }
        public string? Name { get; set; }
        public string? Position { get; set; }
        public List<CourseAuthor>? CourseAuthors { get; set; }
    }
}
