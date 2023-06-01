using AutoMapper;
using DomainLayer.Entities;
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

        public async Task CreateAsync(ContactCreateDto contactCreateDto)
        {
            await _repo.Create(_mapper.Map<Contact>(contactCreateDto));
        }

        public async Task<List<ContactListDto>> GetAllAsync()
        {
            return _mapper.Map<List<ContactListDto>>(await _repo.GetAll());
        }

        public async Task<ContactDto> GetAsync(int id)
        {
            return _mapper.Map<ContactDto>(await _repo.Get(id));
        }

        public async Task UpdateAsync(int id, ContactUpdateDto contactUpdateDto)
        {
            var dbContact = await _repo.Get(id);

            _mapper.Map(contactUpdateDto, dbContact);

            await _repo.Update(dbContact);
        }
    }
}
