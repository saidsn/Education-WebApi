using ServiceLayer.DTOs.Header;

namespace ServiceLayer.Services.Interfaces
{
    public interface IHeaderService
    {
        Task<HeaderDto> GetAsync(int id);
        Task<List<HeaderListDto>> GetAllAsync();
        Task CreateAsync(HeaderCreateDto headerCreateDto);
        Task UpdateAsync(int id, HeaderUpdateDto headerUpdateDto);
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
    }
}
