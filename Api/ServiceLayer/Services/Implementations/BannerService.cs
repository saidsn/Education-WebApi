using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTO_s.Banner;
using ServiceLayer.Helpers;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services.Implementations
{
    public class BannerService : IBannerService
    {
        private readonly IBannerRepository _bannerRepository;
        private readonly IMapper _mapper;

        public BannerService(IBannerRepository bannerRepository, IMapper mapper)
        {
            _bannerRepository = bannerRepository;
            _mapper = mapper;
        }


        public async Task<BannerDto> GetAsync(int id)
        {
            return _mapper.Map<BannerDto>(await _bannerRepository.Get(id));
        }


        public async Task<List<BannerListDto>> GetAllAsync()
        {
            return _mapper.Map<List<BannerListDto>>(await _bannerRepository.GetAll());
        }


        public async Task CreateAsync(BannerCreateDto bannerCreateDto)
        {
            if (!await _bannerRepository.IsExsist(b => b.Title == bannerCreateDto.Title))
            {
                var mapBanner = _mapper.Map<Banner>(bannerCreateDto);

                mapBanner.Image = await bannerCreateDto.Photo.GetBytes();

                await _bannerRepository.Create(mapBanner);
            }
            else
            {
                throw new Exception("Title is already exsist");
            }
        }


        public async Task UpdateAsync(int id, BannerUpdateDto bannerUpdateDto)
        {
            var dbbanner = await _bannerRepository.Get(id);

            var mapBanner = _mapper.Map(bannerUpdateDto, dbbanner);

            mapBanner.Image = await bannerUpdateDto.Photo.GetBytes();

            await _bannerRepository.Update(dbbanner);
        }


        public async Task DeleteAsync(int id)
        {
            await _bannerRepository.Delete(await _bannerRepository.Get(id));
        }


        public async Task SoftDeleteAsync(int id)
        {
            await _bannerRepository.SoftDelete(await _bannerRepository.Get(id));
        }
    }
}
