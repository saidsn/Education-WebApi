using ServiceLayer.DTO_s.Student;

namespace ServiceLayer.Services.Interfaces
{
    public interface IStudentService
    {
        Task<StudentDto> GetAsync(int id);
        Task<List<StudentListDto>> GetAllAsync();
        Task CreateAsync(StudentCreateDto studentCreateDto);
    }
}
