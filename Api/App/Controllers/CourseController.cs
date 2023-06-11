using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTO_s.Course;
using ServiceLayer.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace App.Controllers
{
    public class CourseController : AppController
    {
        private readonly ICourseService _service;

        public CourseController(ICourseService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetById([Required] int id)
        {
            try
            {
                var result = await _service.GetAsync(id);
                return Ok(result);
            }
            catch (Exception)
            {
                return NotFound("Please enter a valid Id!");
            }
        }


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
    }
}
