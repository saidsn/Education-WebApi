using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTO_s.Contact;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services.Implementations
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;
        private readonly IMapper _mapper;

        public ContactService(IContactRepository contactRepository, IMapper mapper)
        {
            _contactRepository = contactRepository;
            _mapper = mapper;
        }


        public async Task<ContactDto> GetAsync(int id)
        {
            return _mapper.Map<ContactDto>(await _contactRepository.Get(id));
        }


        public async Task<List<ContactListDto>> GetAllAsync()
        {
            return _mapper.Map<List<ContactListDto>>(await _contactRepository.GetAll());
        }


        public async Task CreateAsync(ContactCreateDto contactCreateDto)
        {
            await _contactRepository.Create(_mapper.Map<Contact>(contactCreateDto));
        }


        public async Task UpdateAsync(int id, ContactUpdateDto contactUpdateDto)
        {
            var dbContact = await _contactRepository.Get(id);

            _mapper.Map(contactUpdateDto, dbContact);

            await _contactRepository.Update(dbContact);
        }


        public async Task SoftDeleteAsync(int id)
        {
            await _contactRepository.SoftDelete(await _contactRepository.Get(id));
        }
    }
}
