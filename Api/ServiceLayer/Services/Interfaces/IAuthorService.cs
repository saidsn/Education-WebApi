using ServiceLayer.DTO_s.Author;

namespace ServiceLayer.Services.Interfaces
{
    public interface IAuthorService
    {
        //Task<List<AuthorListDto>> GetAllAsync();
        Task CreateAsync(AuthorCreateDto authorCreateDto);
    }
}
