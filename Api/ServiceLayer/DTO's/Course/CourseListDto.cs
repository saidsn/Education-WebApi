namespace ServiceLayer.DTO_s.Course
{
    public class CourseListDto
    {
        public int Id { get; set; }
        public string? Image { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public List<string>? AuthorName { get; set; }
        public List<string>? StudentFullName { get; set; }
    }
}
