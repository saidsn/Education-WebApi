using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services.Implementations
{
    public class BannerService : IBannerService
    {
        private readonly IBannerRepository _repo;
        private readonly IMapper _mapper;

        public BannerService(IBannerRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<Banner> GetAsync(int id)
        {
            var banner = await _repo.Get(id);

            var mapData = _mapper.Map<Banner>(banner);

            return mapData;
        }
    }
}
