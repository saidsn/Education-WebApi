using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTO_s.Student;
using ServiceLayer.Helpers;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services.Implementations
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        public StudentService(IStudentRepository studentRepository,
            ICourseRepository courseRepository,
            IMapper mapper)

        {
            _studentRepository = studentRepository;
            _courseRepository = courseRepository;
            _mapper = mapper;
        }


        public async Task<StudentDto> GetAsync(int id)
        {
            return _mapper.Map<StudentDto>(await _studentRepository.GetWithIncludes(id, "Course"));
        }


        public async Task<List<StudentListDto>> GetAllAsync()
        {
            var students = await _studentRepository.GetAllWithIncludes("Course");

            return students != null
                ? _mapper.Map<List<StudentListDto>>(students)
                : throw new NullReferenceException();
        }


        public async Task CreateAsync(StudentCreateDto studentCreateDto)
        {
            var course = await _courseRepository.Get(studentCreateDto.CourseId);

            var mapStudent = _mapper.Map<Student>(studentCreateDto);

            mapStudent.Image = await studentCreateDto.Photo.GetBytes();

            mapStudent.Course = course;

            await _studentRepository.Create(mapStudent);
        }


        public async Task UpdateAsync(int id, StudentUpdateDto studentUpdateDto)
        {
            var dbStudent = await _studentRepository.GetWithIncludes(id);

            dbStudent.Id = id;
            dbStudent.CourseId = studentUpdateDto.CourseId;

            var mapStudent = _mapper.Map(studentUpdateDto, dbStudent);

            mapStudent.Image = await studentUpdateDto.Photo.GetBytes();

            await _studentRepository.Update(mapStudent);
        }


        public async Task<List<StudentListDto>> SearchAsync(string? searchText)
        {
            List<Student> searchStudents = new();

            searchStudents = searchText != null
                ? await _studentRepository.FindAllExpression(s => s.FullName.Contains(searchText))
                : await _studentRepository.GetAll();

            return _mapper.Map<List<StudentListDto>>(searchStudents);
        }


        public async Task DeleteAsync(int id)
        {
            await _studentRepository.Delete(await _studentRepository.Get(id));
        }


        public async Task SoftDeleteAsync(int id)
        {
            await _studentRepository.SoftDelete(await _studentRepository.Get(id));
        }
    }
}
