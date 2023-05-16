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
            return _mapper.Map<TitleDto>(await _repo.Get(id));
        }

        public async Task<List<TitleListDto>> GetAllAsync()
        {
            return _mapper.Map<List<TitleListDto>>(await _repo.GetAll());
        }

        public async Task CreateAsync(TitleCreateDto titleCreateDto)
        {
            if (!await _repo.IsExsist(t => t.Name == titleCreateDto.Name))
            {
                await _repo.Create(_mapper.Map<Title>(titleCreateDto));
            }
            else
            {
                throw new Exception("Name is already exsist");
            }
        }

        public async Task DeleteAsync(int id)
        {
            await _repo.Delete(await _repo.Get(id));
        }

        public async Task UpdateAsync(int id, TitleUpdateDto titleUpdateDto)
        {
            var dbTitle = await _repo.Get(id);

            var mapData = _mapper.Map(titleUpdateDto, dbTitle);

            await _repo.Update(mapData);
        }
    }
}
