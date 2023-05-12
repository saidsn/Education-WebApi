using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.about;
using ServiceLayer.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace App.Controllers
{
    public class AboutController : AppController
    {
        private readonly IAboutService _service;
        private readonly IWebHostEnvironment _env;

        public AboutController(IAboutService service, IWebHostEnvironment env)
        {
            _service = service;
            _env = env;
        }

        [HttpGet]
        public async Task<IActionResult> Get([Required] int id)
        {
            try
            {
                var about = await _service.GetAsync(id);

                return Ok(about);
            }
            catch (NullReferenceException)
            {

                return NotFound();
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var abouts = await _service.GetAllAsync();

                return Ok(abouts);
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }

        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AboutCreateDto aboutCreateDto)
        {
            await _service.CreateAsync(aboutCreateDto);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([Required] int id)
        {
            try
            {
                await _service.DeleteAsync(id);

                return Ok();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }

    }
}
