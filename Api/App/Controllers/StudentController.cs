using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTO_s.Student;
using ServiceLayer.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace App.Controllers
{
    public class StudentController : AppController
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }


        [HttpGet]
        public async Task<IActionResult> GetById([Required] int id)
        {
            try
            {
                return Ok(await _studentService.GetAsync(id));
            }
            catch (Exception)
            {
                return NotFound($"No records found. Id: {id}");
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _studentService.GetAllAsync());
            }
            catch (Exception)
            {
                return NotFound("No records found!");
            }
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromForm] StudentCreateDto studentCreateDto)
        {
            try
            {
                await _studentService.CreateAsync(studentCreateDto);

                return Ok();
            }
            catch (NullReferenceException)
            {
                return BadRequest(new { ErrorMessage = "Not Created" });
            }
        }


        [HttpPut, Route("{id}")]
        public async Task<IActionResult> Update([FromRoute][Required] int id, [FromForm] StudentUpdateDto studentUpdateDto)
        {
            try
            {
                await _studentService.UpdateAsync(id, studentUpdateDto);

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest(new { ErrorMessage = "Not Updated" });
            }
        }


        [HttpGet]
        public async Task<IActionResult> Search(string? search)
        {
            try
            {
                return Ok(await _studentService.SearchAsync(search));
            }
            catch (Exception)
            {
                return NotFound();
            }
        }


        [HttpDelete]
        public async Task<IActionResult> Delete([Required] int id)
        {
            try
            {
                await _studentService.DeleteAsync(id);

                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }


        [HttpPost]
        public async Task<IActionResult> SoftDelete([Required] int id)
        {
            try
            {
                await _studentService.SoftDeleteAsync(id);

                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
