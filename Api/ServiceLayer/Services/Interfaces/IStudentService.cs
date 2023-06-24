using ServiceLayer.DTO_s.Student;

namespace ServiceLayer.Services.Interfaces
{
    public interface IStudentService
    {
        Task<StudentDto> GetAsync(int id);
        Task<List<StudentListDto>> GetAllAsync();
        Task CreateAsync(StudentCreateDto studentCreateDto);
        Task UpdateAsync(int id, StudentUpdateDto studentUpdateDto);
        Task<List<StudentListDto>> SearchAsync(string? searchText);
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
    }
}
