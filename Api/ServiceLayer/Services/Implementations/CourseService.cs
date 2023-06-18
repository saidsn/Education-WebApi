﻿using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTO_s.Course;
using ServiceLayer.Helpers;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services.Implementations
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public CourseService(ICourseRepository courseRepository,
            IAuthorRepository authorRepository,
            IMapper mapper)
        {
            _courseRepository = courseRepository;
            _authorRepository = authorRepository;
            _mapper = mapper;
        }


        public async Task<CourseDto> GetAsync(int id)
        {
            return _mapper.Map<CourseDto>(await _courseRepository.GetWithAuthorsAndStudentsAsync(id));
        }


        public async Task<List<CourseListDto>> GetAllAsync()
        {
            var courses = await _courseRepository.GetAllWithAuthorsAndStudentsAsync();

            return _mapper.Map<List<CourseListDto>>(courses);
        }


        public async Task CreateAsync(CourseCreateDto courseCreateDto)
        {
            if (courseCreateDto.AuthorIds != null && courseCreateDto.AuthorIds.Any())
            {
                var authors = await _authorRepository.FindAllByExpression(a => courseCreateDto.AuthorIds.Contains(a.Id));

                var mapCourse = _mapper.Map<Course>(courseCreateDto);

                mapCourse.Image = await courseCreateDto.Photo.GetBytes();

                mapCourse.CourseAuthors = new List<CourseAuthor>();

                foreach (var author in authors)
                {
                    var courseAuthor = new CourseAuthor
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
        }

        public async Task UpdateAsync(int id, CourseUpdateDto courseUpdateDto)
        {
            if (courseUpdateDto.AuthorIds != null && courseUpdateDto.AuthorIds.Any())
            {
                var authors = await _courseRepository.FindAllByExpression(a => courseUpdateDto.AuthorIds.Contains(a.Id));

                var dbCourse = await _courseRepository.GetWithAuthorsAndStudentsAsync(id);

                await _courseRepository.DeleteCourseAuthor(dbCourse.CourseAuthors.ToList());

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
        public async Task DeleteAsync(int id)
        {
            await _courseRepository.Delete(await _courseRepository.Get(id));
        }
    }
}
