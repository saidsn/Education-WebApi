using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.about;
using ServiceLayer.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace App.Controllers
{
    public class AboutController : AppController
    {
        private readonly IAboutService _service;

        public AboutController(IAboutService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get([Required] int id)
        {
            try
            {
                return Ok(await _service.GetAsync(id));
            }
            catch (Exception)
            {

                return NotFound();
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _service.GetAllAsync());
            }
            catch (Exception)
            {
                return NotFound();
            }

        }


        [HttpPost]
        public async Task<IActionResult> Create([FromForm] AboutCreateDto aboutCreateDto)
        {
            try
            {
                await _service.CreateAsync(aboutCreateDto);

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest(new { ErrorMessage = "Not Created" });
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([Required] int id)
        {
            try
            {
                await _service.DeleteAsync(id);

                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }



        [HttpPut, Route("{id}")]
        public async Task<IActionResult> Update([FromRoute][Required] int id, [FromForm] AboutUpdateDto aboutUpdateDto)
        {
            try
            {
                await _service.UpdateAsync(id, aboutUpdateDto);

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest(new { ErrorMessage = "Not Updated" });
            }
        }
    }
}
