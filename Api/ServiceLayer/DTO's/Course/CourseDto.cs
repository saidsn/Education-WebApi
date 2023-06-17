namespace ServiceLayer.DTO_s.Course
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string? Image { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public List<string>? AuthorName { get; set; }
        public List<string>? StudentFullName { get; set; }
    }
}
