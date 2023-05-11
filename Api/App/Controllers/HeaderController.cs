using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.Header;
using ServiceLayer.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace App.Controllers
{
    public class HeaderController : AppController
    {
        private readonly IHeaderService _service;
        private readonly IWebHostEnvironment _env;

        public HeaderController(IHeaderService service, IWebHostEnvironment env)
        {
            _service = service;
            _env = env;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync();

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> Get([Required]int id)
        {
            try
            {
                var header = await _service.GetAsync(id);

                return Ok(header);
            }
            catch (NullReferenceException)
            {
                return NotFound();  
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] HeaderCreateDto headerCreateDto)
        {
            await _service.CreateAsync(headerCreateDto);

            return Ok();
        }

      
    }
}
