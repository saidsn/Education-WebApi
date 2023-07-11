using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTO_s.Course;
using ServiceLayer.Helpers;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services.Implementations
{
    public class CourseService : ICourseService
    {
        private readonly ICourseAuthorRepository _courseAuthorRepository;
        private readonly ICourseRepository _courseRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;


        public CourseService(ICourseAuthorRepository courseAuthorRepository,
            ICourseRepository courseRepository,
            IAuthorRepository authorRepository,
            IMapper mapper)

        {
            _courseAuthorRepository = courseAuthorRepository;
            _courseRepository = courseRepository;
            _authorRepository = authorRepository;
            _mapper = mapper;
        }


        public async Task<CourseDto> GetAsync(int id)
        {
            return _mapper.Map<CourseDto>(await _courseRepository.GetWithIncludes(id, "Students", "CourseAuthors.Author"));
        }


        public async Task<List<CourseListDto>> GetAllAsync()
        {
            var courses = await _courseRepository.GetAllWithIncludes("Students", "CourseAuthors.Author");

            return courses != null
                ? _mapper.Map<List<CourseListDto>>(courses)
                : throw new NullReferenceException();
        }


        public async Task CreateAsync(CourseCreateDto courseCreateDto)
        {
            if (courseCreateDto.AuthorIds != null && courseCreateDto.AuthorIds.Any())
            {
                var authors = await _authorRepository.FindAllExpression(a => courseCreateDto.AuthorIds.Contains(a.Id));

                var mapCourse = _mapper.Map<Course>(courseCreateDto);

                mapCourse.Image = await courseCreateDto.Photo.GetBytes();

                mapCourse.CourseAuthors = new List<CourseAuthor>();

                foreach (var author in authors)
                {
                    var courseAuthor = new CourseAuthor
                    {
                        AuthorId = author.Id,
                        CourseId = mapCourse.Id
                    };
                    mapCourse.CourseAuthors.Add(courseAuthor);
                }

                await _courseRepository.Create(mapCourse);
            }
            else
            {
                throw new Exception("You must select at least one author.");
            }
        }


        public async Task UpdateAsync(int id, CourseUpdateDto courseUpdateDto)
        {
            if (courseUpdateDto.AuthorIds != null && courseUpdateDto.AuthorIds.Any())
            {
                var authors = await _authorRepository.FindAllExpression(a => courseUpdateDto.AuthorIds.Contains(a.Id));

                var dbCourse = await _courseRepository.GetWithIncludes(id);

                await _courseAuthorRepository.DeleteList(dbCourse.CourseAuthors.ToList());

                foreach (var author in authors)
                {
                    var courseAuthor = new CourseAuthor
                    {
                        CourseId = id,
                        AuthorId = author.Id
                    };

                    dbCourse.CourseAuthors?.Add(courseAuthor);
                }
                var mapCourse = _mapper.Map(courseUpdateDto, dbCourse);

                mapCourse.Image = await courseUpdateDto.Photo.GetBytes();

                await _courseRepository.Update(mapCourse);
            }
            else
            {
                throw new Exception("You must select at least one author.");
            }
        }


        public async Task<List<CourseListDto>> SearchAsync(string? searchText)
        {
            List<Course> searchCourses = new();

            searchCourses = searchText != null
                ? await _courseRepository.FindAllExpression(c => c.Title.Contains(searchText))
                : await _courseRepository.GetAll();

            return _mapper.Map<List<CourseListDto>>(searchCourses);
        }


        public async Task DeleteAsync(int id)
        {
            await _courseRepository.Delete(await _courseRepository.Get(id));
        }


        public async Task SoftDeleteAsync(int id)
        {
            await _courseRepository.SoftDelete(await _courseRepository.Get(id));
        }
    }
}
