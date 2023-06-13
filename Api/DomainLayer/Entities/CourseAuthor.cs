using DomainLayer.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Entities
{
    public class CourseAuthor : BaseEntity
    {
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course? Course { get; set; }
        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public Author? Author { get; set; }
    }
}
