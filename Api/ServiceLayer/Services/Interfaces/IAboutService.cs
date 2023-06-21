using ServiceLayer.DTOs.about;

namespace ServiceLayer.Services.Interfaces
{
    public interface IAboutService
    {
        Task<AboutDto> GetAsync(int id);
        Task<List<AboutListDto>> GetAllAsync();
        Task CreateAsync(AboutCreateDto aboutCreateDto);
        Task UpdateAsync(int id, AboutUpdateDto aboutUpdateDto);
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
    }
}
