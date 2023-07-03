namespace ServiceLayer.DTO_s.Student
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string? Image { get; set; }
        public string? FullName { get; set; }
        public int Age { get; set; }
        public string? Info { get; set; }
        public bool IsGraduated { get; set; }
        public string? CourseTitle { get; set; }
    }
}
