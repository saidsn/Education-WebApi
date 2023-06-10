namespace ServiceLayer.DTO_s.Author
{
    public class AuthorCreateDto
    {
        public byte[]? Image { get; set; }
        public string? Name { get; set; }
        public string? Position { get; set; }
        public List<int>? CourseIds { get; set; }
    }
}
