using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTO_s.Banner;
using ServiceLayer.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace App.Controllers
{
    public class BannerController : AppController
    {
        private readonly IBannerService _service;

        public BannerController(IBannerService service)
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
        public async Task<IActionResult> Create([FromForm] BannerCreateDto bannerCreateDto)
        {
            try
            {
                await _service.CreateAsync(bannerCreateDto);

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
        public async Task<IActionResult> Update([FromRoute][Required] int id, [FromForm] BannerUpdateDto bannerUpdateDto)
        {
            try
            {
                await _service.UpdateAsync(id, bannerUpdateDto);

                return Ok(bannerUpdateDto);

            }
            catch (Exception)
            {
                return BadRequest(new { ErrorMessage = "Not Updated" });
            }
        }
    }
}
