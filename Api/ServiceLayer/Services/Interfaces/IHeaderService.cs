using ServiceLayer.DTOs.Header;

namespace ServiceLayer.Services.Interfaces
{
    public interface IHeaderService
    {
        Task<HeaderDto> GetAsync(int id);
        Task<List<HeaderListDto>> GetAllAsync();
        Task CreateAsync(HeaderCreateDto headerCreateDto);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id, HeaderUpdateDto headerUpdateDto);
    }
}
