using AutoMapper;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTO_s.Author;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services.Implementations
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _repo;
        private readonly IMapper _mapper;

        public AuthorService(IAuthorRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<List<AuthorListDto>> GetAllAsync()
        {
            return _mapper.Map<List<AuthorListDto>>(await _repo.GetAllAuthor());
        }
    }
}
