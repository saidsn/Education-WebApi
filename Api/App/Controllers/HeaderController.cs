using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.Header;
using ServiceLayer.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace App.Controllers
{
    public class HeaderController : AppController
    {
        private readonly IHeaderService _service;

        public HeaderController(IHeaderService service)
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
        public async Task<IActionResult> Create([FromForm] HeaderCreateDto headerCreateDto)
        {
            try
            {
                await _service.CreateAsync(headerCreateDto);

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
        public async Task<IActionResult> Update([FromRoute][Required] int id, [FromForm] HeaderUpdateDto headerUpdateDto)
        {
            try
            {
                await _service.UpdateAsync(id, headerUpdateDto);

                return Ok(headerUpdateDto);
            }
            catch (Exception)
            {
                return BadRequest(new { ErrorMessage = "Not Updated" });
            }
        }
    }
}
