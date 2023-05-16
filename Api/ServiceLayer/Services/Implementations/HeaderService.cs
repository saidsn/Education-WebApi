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
                await _repo.Create(_mapper.Map<Header>(headerCreateDto));
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

        public async Task<List<HeaderListDto>> GetAllAsync()
        {
            return _mapper.Map<List<HeaderListDto>>(await _repo.GetAll());
        }

        public async Task<HeaderDto> GetAsync(int id)
        {
            return _mapper.Map<HeaderDto>(await _repo.Get(id));
        }

        public async Task UpdateAsync(int id, HeaderUpdateDto headerUpdateDto)
        {
            var dbHeader = await _repo.Get(id);

            _mapper.Map(headerUpdateDto, dbHeader);

            await _repo.Update(dbHeader);
        }
    }
}
