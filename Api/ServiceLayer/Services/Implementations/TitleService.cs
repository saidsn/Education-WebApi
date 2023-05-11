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

        public async Task<List<TitleDto>> GetAllAsync()
        {
            var model = await _repo.GetAll();
            var mapData = _mapper.Map<List<TitleDto>>(model);
            return mapData;
        }
    }
}
