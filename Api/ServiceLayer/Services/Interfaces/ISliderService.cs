using ServiceLayer.DTOs.Product;
using ServiceLayer.DTOs.Slider;

namespace ServiceLayer.Services.Interfaces
{
    public interface ISliderService
    {
        Task CreateAsync(SliderCreateDto sliderCreateDto);
        Task<List<SliderListDto>> GetAllAsync();
        Task DeleteAsync(int id);
        Task UpdateAsync(int id, SliderUpdateDto sliderUpdateDto);
        Task <SliderDto> GetAsync(int id);

    }
}
