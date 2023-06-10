using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTO_s.Student;
using ServiceLayer.Services.Interfaces;

namespace App.Controllers
{
    public class StudentController : AppController
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] StudentCreateDto studentCreateDto)
        {
            try
            {
                await _service.CreateAsync(studentCreateDto);

                return Ok();
            }
            catch (NullReferenceException)
            {
                return BadRequest(new { ErrorMessage = "Not Created" });
            }
        }
    }
}
