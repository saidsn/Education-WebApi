using DomainLayer.Entities;
using ServiceLayer.DTO_s.Banner;

namespace ServiceLayer.Services.Interfaces
{
    public interface IBannerService
    {
        Task<Banner> GetAsync(int id);
        Task<List<BannerListDto>> GetAllAsync();

    }
}
