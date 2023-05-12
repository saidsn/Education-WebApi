using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Title;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services.Implementations
{
    public class TitleService : ITitleService
    {
        private readonly ITitleRepository _repo;
        private readonly IMapper _mapper;

        public TitleService(ITitleRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<TitleDto> GetAsync(int id)
        {
            var title = await _repo.Get(id);

            var mapData = _mapper.Map<TitleDto>(title);

            return mapData;
        }

        public async Task<List<TitleListDto>> GetAllAsync()
        {
            var model = await _repo.GetAll();

            var mapData = _mapper.Map<List<TitleListDto>>(model);

            return mapData;
        }

        public async Task CreateAsync(TitleCreateDto titleCreateDto)
        {
            if (!await _repo.IsExsist(t => t.Name == titleCreateDto.Name))
            {
                var mapData = _mapper.Map<Title>(titleCreateDto);

                await _repo.Create(mapData);
            }
            else
            {
                throw new Exception("Name already exsist");
            }
        }

        public async Task DeleteAsync(int id)
        {
            var title = await _repo.Get(id);

            await _repo.Delete(title);
        }

        public async Task UpdateAsync(int id, TitleUpdateDto titleUpdateDto)
        {
            var dbTitle = await _repo.Get(id);

            var mapData = _mapper.Map(titleUpdateDto, dbTitle);

            await _repo.Update(mapData);
        }
    }
}
