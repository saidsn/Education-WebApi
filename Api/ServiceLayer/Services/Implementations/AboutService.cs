using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.about;
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
                var mapData = _mapper.Map<About>(aboutCreateDto);

                await _repo.Create(mapData);
            }
            else
            {
                throw new Exception("Title is already exsist");
            }
        }

        public async Task DeleteAsync(int id)
        {
            var about = await _repo.Get(id);

            await _repo.Delete(about);
        }

        public async Task<List<AboutListDto>> GetAllAsync()
        {
            var abouts = await _repo.GetAll();

            var mapDatas = _mapper.Map<List<AboutListDto>>(abouts);

            return mapDatas;
        }

        public async Task<AboutDto> GetAsync(int id)
        {
            var about = await _repo.Get(id);

            var mapData = _mapper.Map<AboutDto>(about);

            return mapData;
        }
    }
}
