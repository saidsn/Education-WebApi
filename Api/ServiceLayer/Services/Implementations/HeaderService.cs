using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Header;
using ServiceLayer.Helpers;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services.Implementations
{
    public class HeaderService : IHeaderService
    {
        private readonly IHeaderRepository _headerRepository;
        private readonly IMapper _mapper;


        public HeaderService(IHeaderRepository headerRepository, IMapper mapper)
        {
            _headerRepository = headerRepository;
            _mapper = mapper;
        }


        public async Task<HeaderDto> GetAsync(int id)
        {
            return _mapper.Map<HeaderDto>(await _headerRepository.Get(id));
        }


        public async Task<List<HeaderListDto>> GetAllAsync()
        {
            return _mapper.Map<List<HeaderListDto>>(await _headerRepository.GetAll());
        }


        public async Task CreateAsync(HeaderCreateDto headerCreateDto)
        {
            if (!await _headerRepository.IsExsist(h => h.Title == headerCreateDto.Title))
            {
                var mapHeader = _mapper.Map<Header>(headerCreateDto);

                mapHeader.Image = await headerCreateDto.Photo.GetBytes();

                await _headerRepository.Create(mapHeader);
            }
            else
            {
                throw new Exception("Title is already exsist");
            }
        }


        public async Task UpdateAsync(int id, HeaderUpdateDto headerUpdateDto)
        {
            var dbHeader = await _headerRepository.Get(id);

            var mapHeader = _mapper.Map(headerUpdateDto, dbHeader);

            mapHeader.Image = await headerUpdateDto.Photo.GetBytes();

            await _headerRepository.Update(dbHeader);
        }


        public async Task DeleteAsync(int id)
        {
            await _headerRepository.Delete(await _headerRepository.Get(id));
        }


        public async Task SoftDeleteAsync(int id)
        {
            await _headerRepository.SoftDelete(await _headerRepository.Get(id));
        }
    }
}
