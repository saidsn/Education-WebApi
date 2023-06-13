namespace ServiceLayer.DTO_s.Author
{
    public class AuthorListDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public byte[]? Image { get; set; }
        public string? Position { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public List<string>? CourseTitle { get; set; }
    }
}
