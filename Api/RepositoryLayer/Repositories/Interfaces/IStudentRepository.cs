using DomainLayer.Entities;

namespace RepositoryLayer.Repositories.Interfaces
{
    public interface IStudentRepository : IRepository<Student>
    {
        Task<Student> GetWithCoursesAsync(int id);
        Task<List<Student>> GetAllWithCoursesAsync();
    }
}
