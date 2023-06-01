using ServiceLayer.DTO_s.Contact;

namespace ServiceLayer.Services.Interfaces
{
    public interface IContactService
    {
        Task<ContactDto> GetAsync(int id);

    }
}
