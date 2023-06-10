using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTO_s.Student;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services.Implementations
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        public StudentService(IStudentRepository studentRepository, ICourseRepository courseRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _courseRepository = courseRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(StudentCreateDto studentCreateDto)
        {
            var course = await _courseRepository.Get(studentCreateDto.CourseId);

            var mapData = _mapper.Map<Student>(studentCreateDto);

            mapData.Course = course;

            await _studentRepository.Create(mapData);
        }
    }
}
