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

        private readonly ISliderRepository _repo;
        private readonly IMapper _mapper;

        public SliderService(ISliderRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }


        public async Task CreateAsync(SliderCreateDto sliderCreateDto)
        {
            var mapSlider = _mapper.Map<Slider>(sliderCreateDto);

            mapSlider.Image = await sliderCreateDto.Photo.GetBytes();

            await _repo.Create(mapSlider);
        }


        public async Task DeleteAsync(int id)
        {
            await _repo.Delete(await _repo.Get(id));
        }


        public async Task<List<SliderListDto>> GetAllAsync()
        {
            return _mapper.Map<List<SliderListDto>>(await _repo.GetAll());
        }


        public async Task<SliderDto> GetAsync(int id)
        {
            return _mapper.Map<SliderDto>(await _repo.Get(id));
        }

        public async Task UpdateAsync(int id, SliderUpdateDto sliderUpdateDto)
        {
            var dbSlider = await _repo.Get(id);

            var mapSlider = _mapper.Map(sliderUpdateDto, dbSlider);

            mapSlider.Image = await sliderUpdateDto.Photo.GetBytes();

            await _repo.Update(dbSlider);
        }
    }
}
