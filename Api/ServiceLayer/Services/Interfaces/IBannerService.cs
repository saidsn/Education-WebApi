using ServiceLayer.DTO_s.Banner;

namespace ServiceLayer.Services.Interfaces
{
    public interface IBannerService
    {
        Task<BannerDto> GetAsync(int id);
        Task<List<BannerListDto>> GetAllAsync();
        Task CreateAsync(BannerCreateDto bannerCreateDto);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id, BannerUpdateDto bannerUpdateDto);
    }
}
