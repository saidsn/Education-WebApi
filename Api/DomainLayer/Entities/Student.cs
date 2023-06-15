using DomainLayer.Common;

namespace DomainLayer.Entities
{
    public class Student : BaseEntity
    {
        public byte[]? Image { get; set; }
        public string? FullName { get; set; }
        public int Age { get; set; }
        public string? Info { get; set; }
        public bool IsGraduated { get; set; }
        public int CourseId { get; set; }
        public Course? Course { get; set; }
    }
}
