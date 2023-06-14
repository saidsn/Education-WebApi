using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTO_s.Service;
using ServiceLayer.Helpers;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services.Implementations
{
    public class ServiceService : IServiceService
    {
        private readonly IServiceRepository _repo;
        private readonly IMapper _mapper;

        public ServiceService(IServiceRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<ServiceDto> GetAsync(int id)
        {
            return _mapper.Map<ServiceDto>(await _repo.Get(id));
        }
        public async Task<List<ServiceListDto>> GetAllAsync()
        {
            return _mapper.Map<List<ServiceListDto>>(await _repo.GetAll());
        }

        public async Task CreateAsync(ServiceCreateDto serviceCreateDto)
        {
            if (!await _repo.IsExsist(s => s.Title == serviceCreateDto.Title))
            {
                var mapService = _mapper.Map<Service>(serviceCreateDto);

                mapService.Image = await serviceCreateDto.Photo.GetBytes();

                await _repo.Create(mapService);
            }
            else
            {
                throw new Exception("Service is already exsist");
            }
        }

        public async Task DeleteAsync(int id)
        {
            await _repo.Delete(await _repo.Get(id));
        }

        public async Task UpdateAsync(int id, ServiceUpdateDto serviceUpdateDto)
        {
            var dbService = await _repo.Get(id);

            var mapService = _mapper.Map(serviceUpdateDto, dbService);

            mapService.Image = await serviceUpdateDto.Photo.GetBytes();

            await _repo.Update(dbService);
        }
    }
}
