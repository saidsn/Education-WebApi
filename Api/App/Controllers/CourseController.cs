using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTO_s.Course;
using ServiceLayer.Services.Interfaces;

namespace App.Controllers
{
    public class CourseController : AppController
    {
        private readonly ICourseService _service;

        public CourseController(ICourseService service)
        {
            _service = service;
        }

        //[HttpGet]
        //public async Task<IActionResult> GetAll()
        //{
        //    try
        //    {
        //        return Ok(await _service.GetAllAsync());
        //    }
        //    catch (NullReferenceException)
        //    {

        //        return NotFound();
        //    }
        //}

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CourseCreateDto courseCreateDto)
        {
            try
            {
                await _service.CreateAsync(courseCreateDto);

                return Ok();
            }
            catch (NullReferenceException)
            {
                return BadRequest(new { ErrorMessage = "Not Created" });
            }
        }
    }
}
