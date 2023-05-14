using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTO_s.Banner;
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

        public async Task CreateAsync(BannerCreateDto bannerCreateDto)
        {
            if (!await _repo.IsExsist(b => b.Title == bannerCreateDto.Title))
            {
                await _repo.Create(_mapper.Map<Banner>(bannerCreateDto));
            }
            else
            {
                throw new Exception("Title is already exsist");
            }
        }

        public async Task<List<BannerListDto>> GetAllAsync()
        {
            return _mapper.Map<List<BannerListDto>>(await _repo.GetAll());
        }

        public async Task<BannerDto> GetAsync(int id)
        {
            return _mapper.Map<BannerDto>(await _repo.Get(id));
        }
    }
}
