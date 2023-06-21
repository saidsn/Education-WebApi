using ServiceLayer.DTOs.Title;

namespace ServiceLayer.Services.Interfaces
{
    public interface ITitleService
    {
        Task<TitleDto> GetAsync(int id);
        Task<List<TitleListDto>> GetAllAsync();
        Task CreateAsync(TitleCreateDto titleCreateDto);
        Task UpdateAsync(int id, TitleUpdateDto titleUpdateDto);
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
    }
}
