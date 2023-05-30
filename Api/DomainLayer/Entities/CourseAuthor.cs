using DomainLayer.Common;

namespace DomainLayer.Entities
{
    public class CourseAuthor : BaseEntity
    {
        public int CourseId { get; set; }
        public Course? Course { get; set; }
        public int AuthorId { get; set; }
        public Author? Author { get; set; }
    }
}
