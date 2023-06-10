using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTO_s.Course;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services.Implementations
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public CourseService(ICourseRepository courseRepository, IAuthorRepository authorRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _authorRepository = authorRepository;
            _mapper = mapper;
        }


        //public async Task CreateAsync(CourseCreateDto courseCreateDto)
        //{
        //    var mapCourse = _mapper.Map<Course>(courseCreateDto);

        //    mapCourse.CourseAuthors = new List<CourseAuthor>();

        //    if (courseCreateDto.authorIds != null && courseCreateDto.authorIds.Any())
        //    {
        //        foreach (var authorId in courseCreateDto.authorIds)
        //        {
        //            var author = await _authorRepository.Get(authorId);
        //            if (author != null)
        //            {
        //                var courseAuthor = new CourseAuthor
        //                {
        //                    Course = mapCourse,
        //                    Author = author
        //                };
        //                mapCourse.CourseAuthors.Add(courseAuthor);
        //            }
        //        }
        //    }

        //    await _courseRepository.Create(mapCourse);
        //}


        public async Task CreateAsync(CourseCreateDto courseCreateDto)
        {
            if (courseCreateDto.AuthorIds != null && courseCreateDto.AuthorIds.Any())
            {
                var authors = await _authorRepository.FindAllByExpression(a => courseCreateDto.AuthorIds.Contains(a.Id));

                var mapCourse = _mapper.Map<Course>(courseCreateDto);

                mapCourse.CourseAuthors = new List<CourseAuthor>();

                foreach (var author in authors)
                {
                    CourseAuthor courseAuthor = new CourseAuthor
                    {
                        Course = mapCourse,
                        Author = author
                    };
                    mapCourse.CourseAuthors.Add(courseAuthor);
                }

                await _courseRepository.Create(mapCourse);
            }
            else
            {
                throw new Exception("You must select at least one author.");
            }




            //public async Task CreateCourse(Course course, int[] authorIds)
            //{
            //    var authors = await _authorRepo.FindAllByExpression(a => authorIds.Contains(a.Id));

            //    course.CourseAuthors = new List<CourseAuthor>();

            //    foreach (var author in authors)
            //    {
            //        course.CourseAuthors.Add(new CourseAuthor
            //        {
            //            AuthorId = author.Id,
            //            CourseId = course.Id,
            //        });
            //    }

            //    await _context.SaveChangesAsync();
            //}



        }




        //public async Task CreateAsync(StudentCreateDto studentCreateDto)
        //{
        //    var course = await _courseRepository.Get(studentCreateDto.CourseId);

        //    var mapData = _mapper.Map<Student>(studentCreateDto);

        //    mapData.Course = course;

        //    await _studentRepository.Create(mapData);
        //}














        //public async Task<List<CourseListDto>> GetAllAsync()
        //{
        //    return _mapper.Map<List<CourseListDto>>(await _repo.GetAllCourse());
        //}

        //public async Task<CourseDto> GetAsync(int id)
        //{
        //    return _mapper.Map<CourseDto>(await _repo.Get(id));
        //}
    }
}
