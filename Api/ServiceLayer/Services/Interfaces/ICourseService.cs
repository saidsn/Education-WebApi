using ServiceLayer.DTO_s.Course;

namespace ServiceLayer.Services.Interfaces
{
    public interface ICourseService
    {
        Task<CourseDto> GetAsync(int id);
        Task<List<CourseListDto>> GetAllAsync();
        Task CreateAsync(CourseCreateDto courseCreateDto);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id, CourseUpdateDto courseUpdateDto);
    }
}
