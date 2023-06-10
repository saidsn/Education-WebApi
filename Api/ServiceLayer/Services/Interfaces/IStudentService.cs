using ServiceLayer.DTO_s.Student;

namespace ServiceLayer.Services.Interfaces
{
    public interface IStudentService
    {
        Task CreateAsync(StudentCreateDto studentCreateDto);
    }
}
