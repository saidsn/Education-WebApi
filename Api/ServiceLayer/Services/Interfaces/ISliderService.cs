using ServiceLayer.DTOs.Product;
using ServiceLayer.DTOs.Slider;

namespace ServiceLayer.Services.Interfaces
{
    public interface ISliderService
    {
        Task<SliderDto> GetAsync(int id);
        Task<List<SliderListDto>> GetAllAsync();
        Task CreateAsync(SliderCreateDto sliderCreateDto);
        Task UpdateAsync(int id, SliderUpdateDto sliderUpdateDto);
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
    }
}
