using ServiceLayer.DTOs.Header;

namespace ServiceLayer.Services.Interfaces
{
    public interface IHeaderService
    {
        Task<List<HeaderListDto>> GetAllAsync();
        Task<HeaderDto> GetAsync(int id);
        Task CreateAsync(HeaderCreateDto headerCreateDto);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id, HeaderUpdateDto headerUpdateDto);
    }
}
