using ServiceLayer.DTOs.Product;
using ServiceLayer.DTOs.Slider;

namespace ServiceLayer.Services.Interfaces
{
    public interface ISliderService
    {
        Task<SliderDto> GetAsync(int id);
        Task<List<SliderListDto>> GetAllAsync();
        Task CreateAsync(SliderCreateDto sliderCreateDto);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id, SliderUpdateDto sliderUpdateDto);
    }
}
