using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Product;
using ServiceLayer.DTOs.Slider;
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
            if (!await _repo.IsExsist(s => s.Title == sliderCreateDto.Title))
            {
                var mapData = _mapper.Map<Slider>(sliderCreateDto);

                await _repo.Create(mapData);
            }
            else
            {
                throw new Exception("Title is already exsist");
            }
        }



        public async Task DeleteAsync(int id)
        {
            var slider = await _repo.Get(id);

            await _repo.Delete(slider);
        }


        public async Task<List<SliderListDto>> GetAllAsync()
        {
            var sliders = await _repo.GetAll();

            var mapData = _mapper.Map<List<SliderListDto>>(sliders);

            return mapData;
        }


        public async Task<SliderDto> GetAsync(int id)
        {
            var slider = await _repo.Get(id);

            var mapData = _mapper.Map<SliderDto>(slider);

            return mapData;
        }

        public async Task UpdateAsync(int id, SliderUpdateDto sliderUpdateDto)
        {
            var dbSlider = await _repo.Get(id);

            _mapper.Map(sliderUpdateDto, dbSlider);

            await _repo.Update(dbSlider);
        }
    }
}
