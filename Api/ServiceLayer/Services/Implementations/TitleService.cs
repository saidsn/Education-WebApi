using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Title;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var mapData = _mapper.Map<Title>(titleCreateDto);

            await _repo.Create(mapData);
        }
    }
}
