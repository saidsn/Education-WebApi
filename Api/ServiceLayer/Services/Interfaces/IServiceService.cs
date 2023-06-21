using ServiceLayer.DTO_s.Service;

namespace ServiceLayer.Services.Interfaces
{
    public interface IServiceService
    {
        Task<ServiceDto> GetAsync(int id);
        Task<List<ServiceListDto>> GetAllAsync();
        Task CreateAsync(ServiceCreateDto serviceCreateDto);
        Task UpdateAsync(int id, ServiceUpdateDto serviceUpdateDto);
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
    }
}
