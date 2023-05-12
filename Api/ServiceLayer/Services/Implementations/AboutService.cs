using AutoMapper;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.about;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services.Implementations
{
    public class AboutService : IAboutService
    {

        private readonly IAboutRepository _repo;
        private readonly IMapper _mapper;

        public AboutService(IAboutRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<AboutDto> GetAsync(int id)
        {
            var about = await _repo.Get(id);

            var mapData = _mapper.Map<AboutDto>(about);

            return mapData;
        }
    }
}
