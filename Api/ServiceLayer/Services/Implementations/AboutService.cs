using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.about;
using ServiceLayer.Helpers;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services.Implementations
{
    public class AboutService : IAboutService
    {
        private readonly IAboutRepository _aboutRepository;
        private readonly IMapper _mapper;

        public AboutService(IAboutRepository aboutRepository, IMapper mapper)
        {
            _aboutRepository = aboutRepository;
            _mapper = mapper;
        }


        public async Task CreateAsync(AboutCreateDto aboutCreateDto)
        {
            if (!await _aboutRepository.IsExsist(a => a.Title == aboutCreateDto.Title))
            {
                var mapAbout = _mapper.Map<About>(aboutCreateDto);

                mapAbout.Image = await aboutCreateDto.Photo.GetBytes();

                await _aboutRepository.Create(mapAbout);
            }
            else
            {
                throw new Exception("Title is already exsist");
            }
        }


        public async Task DeleteAsync(int id)
        {
            await _aboutRepository.Delete(await _aboutRepository.Get(id));
        }


        public async Task SoftDeleteAsync(int id)
        {
            await _aboutRepository.SoftDelete(await _aboutRepository.Get(id));
        }


        public async Task<List<AboutListDto>> GetAllAsync()
        {
            return _mapper.Map<List<AboutListDto>>(await _aboutRepository.GetAll());
        }


        public async Task<AboutDto> GetAsync(int id)
        {
            return _mapper.Map<AboutDto>(await _aboutRepository.Get(id));
        }


        public async Task UpdateAsync(int id, AboutUpdateDto aboutUpdateDto)
        {
            var dbAbout = await _aboutRepository.Get(id);

            var mapAbout = _mapper.Map(aboutUpdateDto, dbAbout);

            mapAbout.Image = await aboutUpdateDto.Photo.GetBytes();

            await _aboutRepository.Update(mapAbout);
        }
    }
}
