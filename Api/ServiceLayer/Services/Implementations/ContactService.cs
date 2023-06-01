using AutoMapper;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTO_s.Contact;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services.Implementations
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _repo;
        private readonly IMapper _mapper;

        public ContactService(IContactRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<ContactDto> GetAsync(int id)
        {
            return _mapper.Map<ContactDto>(await _repo.Get(id));
        }
    }
}
