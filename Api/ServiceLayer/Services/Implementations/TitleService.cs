using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Title;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services.Implementations
{
    public class TitleService : ITitleService
    {
        private readonly ITitleRepository _titleRepository;
        private readonly IMapper _mapper;

        public TitleService(ITitleRepository titleRepository, IMapper mapper)
        {
            _titleRepository = titleRepository;
            _mapper = mapper;
        }


        public async Task<TitleDto> GetAsync(int id)
        {
            return _mapper.Map<TitleDto>(await _titleRepository.Get(id));
        }


        public async Task<List<TitleListDto>> GetAllAsync()
        {
            return _mapper.Map<List<TitleListDto>>(await _titleRepository.GetAll());
        }


        public async Task CreateAsync(TitleCreateDto titleCreateDto)
        {
            if (!await _titleRepository.IsExsist(t => t.Name == titleCreateDto.Name))
            {
                await _titleRepository.Create(_mapper.Map<Title>(titleCreateDto));
            }
            else
            {
                throw new Exception("Name is already exsist");
            }
        }


        public async Task UpdateAsync(int id, TitleUpdateDto titleUpdateDto)
        {
            var dbTitle = await _titleRepository.Get(id);

            _mapper.Map(titleUpdateDto, dbTitle);

            await _titleRepository.Update(dbTitle);
        }


        public async Task DeleteAsync(int id)
        {
            await _titleRepository.Delete(await _titleRepository.Get(id));
        }


        public async Task SoftDeleteAsync(int id)
        {
            await _titleRepository.SoftDelete(await _titleRepository.Get(id));
        }
    }
}
