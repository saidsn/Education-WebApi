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
        private readonly IAboutRepository _repo;
        private readonly IMapper _mapper;

        public AboutService(IAboutRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateAsync(AboutCreateDto aboutCreateDto)
        {
            if (!await _repo.IsExsist(a => a.Title == aboutCreateDto.Title))
            {
                var mapAbout = _mapper.Map<About>(aboutCreateDto);

                mapAbout.Image = await aboutCreateDto.Photo.GetBytes();

                await _repo.Create(mapAbout);
            }
            else
            {
                throw new Exception("Title is already exsist");
            }
        }

        public async Task DeleteAsync(int id)
        {
            await _repo.Delete(await _repo.Get(id));
        }


        public async Task<List<AboutListDto>> GetAllAsync()
        {
            return _mapper.Map<List<AboutListDto>>(await _repo.GetAll());
        }

        public async Task<AboutDto> GetAsync(int id)
        {
            return _mapper.Map<AboutDto>(await _repo.Get(id));
        }

        public async Task UpdateAsync(int id, AboutUpdateDto aboutUpdateDto)
        {
            var dbAbout = await _repo.Get(id);

            var mapAbout = _mapper.Map(aboutUpdateDto, dbAbout);

            mapAbout.Image = await aboutUpdateDto.Photo.GetBytes();

            await _repo.Update(dbAbout);
        }
    }
}
