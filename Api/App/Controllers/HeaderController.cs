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
        public async Task<IActionResult> Get([Required] int id)
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

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var result = await _service.GetAllAsync();

                return Ok(result);
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

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([Required][FromRoute] int id, HeaderUpdateDto headerUpdateDto)
        {
            try
            {
                await _service.UpdateAsync(id, headerUpdateDto);

                return Ok(headerUpdateDto);
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }
    }
}
