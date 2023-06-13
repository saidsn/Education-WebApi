using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTO_s.Author;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services.Implementations
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        public AuthorService(IAuthorRepository authorRepository, ICourseRepository courseRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _courseRepository = courseRepository;
            _mapper = mapper;
        }


        public async Task<AuthorDto> GetAsync(int id)
        {
            return _mapper.Map<AuthorDto>(await _authorRepository.Get(id));
        }


        public async Task<List<AuthorListDto>> GetAllAsync()
        {
            var authors = await _authorRepository.GetAllWithCoursesAsync();

            return _mapper.Map<List<AuthorListDto>>(authors);
        }

        public async Task CreateAsync(AuthorCreateDto authorCreateDto)
        {
            if (authorCreateDto.CourseIds != null && authorCreateDto.CourseIds.Any())
            {
                var courses = await _courseRepository.FindAllByExpression(c => authorCreateDto.CourseIds.Contains(c.Id));

                var mapAuthor = _mapper.Map<Author>(authorCreateDto);

                mapAuthor.CourseAuthors = new List<CourseAuthor>();

                foreach (var course in courses)
                {
                    var courseAuthor = new CourseAuthor
                    {
                        Course = course,
                        Author = mapAuthor
                    };
                    mapAuthor.CourseAuthors.Add(courseAuthor);
                }

                await _authorRepository.Create(mapAuthor);
            }
            else
            {
                throw new Exception("You must select at least one course.");
            }
        }

    }
}
