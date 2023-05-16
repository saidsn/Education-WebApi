using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTO_s.Banner;
using ServiceLayer.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace App.Controllers
{
    public class BannerController : AppController
    {
        private readonly IBannerService _service;
        private readonly IWebHostEnvironment _env;

        public BannerController(IBannerService service, IWebHostEnvironment env)
        {
            _service = service;
            _env = env;
        }

        [HttpGet]
        public async Task<IActionResult> Get([Required] int id)
        {
            try
            {
                return Ok(await _service.GetAsync(id));
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
                return Ok(await _service.GetAllAsync());
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] BannerCreateDto bannerCreateDto)
        {
            await _service.CreateAsync(bannerCreateDto);

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

        [HttpPut, Route("{id}")]
        public async Task<IActionResult> Update([FromRoute][Required] int id, BannerUpdateDto bannerUpdateDto)
        {
            try
            {
                await _service.UpdateAsync(id, bannerUpdateDto);

                return Ok(bannerUpdateDto);

            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }
    }
}
