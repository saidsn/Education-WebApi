using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.Slider;
using ServiceLayer.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace App.Controllers
{
    public class SliderController : AppController
    {
        private readonly ISliderService _service;
        private readonly IWebHostEnvironment _env;

        public SliderController(ISliderService service, IWebHostEnvironment env)
        {
            _service = service;
            _env = env;
        }


        [HttpGet]
        public async Task<IActionResult> Get([Required] int id)
        {
            try
            {
                var slider = await _service.GetAsync(id);

                return Ok(slider);
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
        public async Task<IActionResult> Create([FromBody] SliderCreateDto sliderCreateDto)
        {
            await _service.CreateAsync(sliderCreateDto);
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
        public async Task<IActionResult> Update([FromRoute][Required] int id, SliderUpdateDto sliderUpdateDto)
        {
            try
            {
                await _service.UpdateAsync(id, sliderUpdateDto);

                return Ok(sliderUpdateDto);
            }
            catch (NullReferenceException)
            {

                return NotFound();
            }
        }
    }
}
