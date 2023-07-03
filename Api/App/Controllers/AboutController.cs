using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.about;
using ServiceLayer.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace App.Controllers
{
    public class AboutController : AppController
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public async Task<IActionResult> GetById([Required] int id)
        {
            try
            {
                return Ok(await _aboutService.GetAsync(id));
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
                return Ok(await _aboutService.GetAllAsync());
            }
            catch (Exception)
            {
                return NotFound("No records found!");
            }

        }


        [HttpPost]
        public async Task<IActionResult> Create([FromForm] AboutCreateDto aboutCreateDto)
        {
            try
            {
                await _aboutService.CreateAsync(aboutCreateDto);

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
                await _aboutService.DeleteAsync(id);

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
                await _aboutService.SoftDeleteAsync(id);

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
                await _aboutService.UpdateAsync(id, aboutUpdateDto);

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest(new { ErrorMessage = "Not Updated" });
            }
        }
    }
}
