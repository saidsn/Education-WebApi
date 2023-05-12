using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.Title;
using ServiceLayer.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace App.Controllers
{
    public class TitleController : AppController
    {
        private readonly ITitleService _service;
        private readonly IWebHostEnvironment _env;

        public TitleController(ITitleService service, IWebHostEnvironment env)
        {
            _service = service;
            _env = env;
        }


        [HttpGet]
        public async Task<IActionResult> Get([Required] int id)
        {
            try
            {
                var title = await _service.GetAsync(id);

                return Ok(title);
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
        public async Task<IActionResult> Create([FromBody] TitleCreateDto titleCreateDto)
        {
            await _service.CreateAsync(titleCreateDto);

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
        public async Task<IActionResult> Update([Required][FromRoute] int id, TitleUpdateDto titleUpdateDto)
        {
            try
            {
                await _service.UpdateAsync(id, titleUpdateDto);

                return Ok(titleUpdateDto);
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }

    }
}
