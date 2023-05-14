using DomainLayer.Entities;

namespace ServiceLayer.Services.Interfaces
{
    public interface IBannerService
    {
        Task<Banner> GetAsync(int id);
    }
}
