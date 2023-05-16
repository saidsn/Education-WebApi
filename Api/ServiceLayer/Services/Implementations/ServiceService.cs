using AutoMapper;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTO_s.Service;
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


    }
}
