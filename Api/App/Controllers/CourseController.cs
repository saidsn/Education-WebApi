using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTO_s.Course;
using ServiceLayer.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace App.Controllers
{
    public class CourseController : AppController
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public async Task<IActionResult> GetById([Required] int id)
        {
            try
            {
                var result = await _courseService.GetAsync(id);
                return Ok(result);
            }
            catch (Exception)
            {
                return NotFound("Please enter a valid Id!");
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var result = await _courseService.GetAllAsync();

                return Ok(result);
            }
            catch (NullReferenceException)
            {
                return NotFound("No records found!");
            }
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CourseCreateDto courseCreateDto)
        {
            try
            {
                await _courseService.CreateAsync(courseCreateDto);

                return Ok();
            }
            catch (NullReferenceException)
            {
                return BadRequest(new { ErrorMessage = "Not Created" });
            }
        }
    }
}
