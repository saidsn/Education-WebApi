using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Header;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var mapData = _mapper.Map<Header>(headerCreateDto);
            
            await _repo.Create(mapData);
        }

        public async Task<List<HeaderDto>> GetAllAsync()
        {
            var model = await _repo.GetAll();
            var mapData = _mapper.Map<List<HeaderDto>>(model);
            return mapData;
        }

        public async Task<HeaderDto> GetAsync(int id)
        {
            var header = await _repo.Get(id);

            var mapData = _mapper.Map<HeaderDto>(header);

            return mapData;
        }
    }
}
