using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Product;
using ServiceLayer.DTOs.Slider;
using ServiceLayer.Helpers;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services.Implementations
{
    public class SliderService : ISliderService
    {

        private readonly ISliderRepository _sliderRepository;
        private readonly IMapper _mapper;

        public SliderService(ISliderRepository sliderRepository, IMapper mapper)
        {
            _sliderRepository = sliderRepository;
            _mapper = mapper;
        }


        public async Task<SliderDto> GetAsync(int id)
        {
            return _mapper.Map<SliderDto>(await _sliderRepository.Get(id));
        }


        public async Task<List<SliderListDto>> GetAllAsync()
        {
            return _mapper.Map<List<SliderListDto>>(await _sliderRepository.GetAll());
        }


        public async Task CreateAsync(SliderCreateDto sliderCreateDto)
        {
            var mapSlider = _mapper.Map<Slider>(sliderCreateDto);

            mapSlider.Image = await sliderCreateDto.Photo.GetBytes();

            await _sliderRepository.Create(mapSlider);
        }


        public async Task UpdateAsync(int id, SliderUpdateDto sliderUpdateDto)
        {
            var dbSlider = await _sliderRepository.Get(id);

            var mapSlider = _mapper.Map(sliderUpdateDto, dbSlider);

            mapSlider.Image = await sliderUpdateDto.Photo.GetBytes();

            await _sliderRepository.Update(dbSlider);
        }


        public async Task DeleteAsync(int id)
        {
            await _sliderRepository.Delete(await _sliderRepository.Get(id));
        }


        public async Task SoftDeleteAsync(int id)
        {
            await _sliderRepository.SoftDelete(await _sliderRepository.Get(id));
        }
    }
}
