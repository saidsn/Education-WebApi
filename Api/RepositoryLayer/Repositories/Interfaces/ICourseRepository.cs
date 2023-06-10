using DomainLayer.Entities;


namespace RepositoryLayer.Repositories.Interfaces
{
    public interface ICourseRepository : IRepository<Course>
    {
        //Task<List<Course>> GetAllCourse();
        Task CreateCourse(Course course, int[] authorIds);
    }
}
