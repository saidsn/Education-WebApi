using ServiceLayer.DTO_s.Student;

namespace ServiceLayer.Services.Interfaces
{
    public interface IStudentService
    {
        Task<StudentDto> GetAsync(int id);
        Task CreateAsync(StudentCreateDto studentCreateDto);
    }
}
