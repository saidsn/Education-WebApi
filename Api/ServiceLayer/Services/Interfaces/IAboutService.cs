using ServiceLayer.DTOs.about;

namespace ServiceLayer.Services.Interfaces
{
    public interface IAboutService
    {
        Task<AboutDto> GetAsync(int id);
    }
}
