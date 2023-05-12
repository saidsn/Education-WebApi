using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Header;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services.Implementations
{
    public class HeaderService : IHeaderService
    {
        private readonly IHeaderRepository _repo;
        private readonly IMapper _mapper;


        public HeaderService(IHeaderRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateAsync(HeaderCreateDto headerCreateDto)
        {
            if (!await _repo.IsExsist(h => h.Title == headerCreateDto.Title))
            {
                var mapData = _mapper.Map<Header>(headerCreateDto);

                await _repo.Create(mapData);
            }
            else
            {
                throw new Exception("Title is already exsist");
            }
        }

        public async Task DeleteAsync(int id)
        {
            var header = await _repo.Get(id);

            await _repo.Delete(header);
        }

        public async Task<List<HeaderListDto>> GetAllAsync()
        {
            var headers = await _repo.GetAll();

            var mapDatas = _mapper.Map<List<HeaderListDto>>(headers);

            return mapDatas;
        }

        public async Task<HeaderDto> GetAsync(int id)
        {
            var header = await _repo.Get(id);

            var mapData = _mapper.Map<HeaderDto>(header);

            return mapData;
        }

        public async Task UpdateAsync(int id, HeaderUpdateDto headerUpdateDto)
        {
            var dbHeader = await _repo.Get(id);

            _mapper.Map(headerUpdateDto, dbHeader);

            await _repo.Update(dbHeader);
        }
    }
}
