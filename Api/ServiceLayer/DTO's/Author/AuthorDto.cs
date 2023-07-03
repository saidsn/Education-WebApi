namespace ServiceLayer.DTO_s.Author
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string? Image { get; set; }
        public string? Name { get; set; }
        public string? Position { get; set; }
        public List<string>? CourseTitle { get; set; }
    }
}
