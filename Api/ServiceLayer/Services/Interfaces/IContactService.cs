using ServiceLayer.DTO_s.Contact;

namespace ServiceLayer.Services.Interfaces
{
    public interface IContactService
    {
        Task<ContactDto> GetAsync(int id);
        Task<List<ContactListDto>> GetAllAsync();
        Task CreateAsync(ContactCreateDto contactCreateDto);
        Task UpdateAsync(int id, ContactUpdateDto contactUpdateDto);
        Task SoftDeleteAsync(int id);
    }
}
