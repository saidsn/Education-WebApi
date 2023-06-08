using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTO_s.Course;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services.Implementations
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _repo;
        private readonly IMapper _mapper;

        public CourseService(ICourseRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateAsync(CourseCreateDto courseCreateDto)
        {
            var mapData = _mapper.Map<Course>(courseCreateDto);
            await _repo.Create(mapData);
            await _repo.CreateCourse(mapData, courseCreateDto.authorIds);
        }

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
