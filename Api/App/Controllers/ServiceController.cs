using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTO_s.Service;
using ServiceLayer.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace App.Controllers
{
    public class ServiceController : AppController
    {
        private readonly IServiceService _service;
        private readonly IWebHostEnvironment _env;

        public ServiceController(IServiceService service, IWebHostEnvironment env = null)
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
        public async Task<IActionResult> Create([FromBody] ServiceCreateDto serviceCreateDto)
        {
            await _service.CreateAsync(serviceCreateDto);

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
        public async Task<IActionResult> Update([Required][FromRoute] int id, ServiceUpdateDto serviceUpdateDto)
        {
            try
            {
                await _service.UpdateAsync(id, serviceUpdateDto);

                return Ok();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }
    }
}
