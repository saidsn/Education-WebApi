namespace ServiceLayer.DTO_s.Student
{
    public class StudentCreateDto
    {
        public byte[]? Image { get; set; }
        public string? FullName { get; set; }
        public int Age { get; set; }
        public string? Info { get; set; }
        public bool IsGraduated { get; set; }
        public int CourseId { get; set; }
    }
}
