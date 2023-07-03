using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.Header;
using ServiceLayer.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace App.Controllers
{
    public class HeaderController : AppController
    {
        private readonly IHeaderService _headerService;

        public HeaderController(IHeaderService headerService)
        {
            _headerService = headerService;
        }


        [HttpGet]
        public async Task<IActionResult> GetById([Required] int id)
        {
            try
            {
                return Ok(await _headerService.GetAsync(id));
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
                return Ok(await _headerService.GetAllAsync());
            }
            catch (Exception)
            {
                return NotFound("No records found!");
            }
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromForm] HeaderCreateDto headerCreateDto)
        {
            try
            {
                await _headerService.CreateAsync(headerCreateDto);

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
                await _headerService.DeleteAsync(id);
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
                await _headerService.SoftDeleteAsync(id);

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
                await _headerService.UpdateAsync(id, headerUpdateDto);

                return Ok(headerUpdateDto);
            }
            catch (Exception)
            {
                return BadRequest(new { ErrorMessage = "Not Updated" });
            }
        }
    }
}
