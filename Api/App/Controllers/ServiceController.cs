using Microsoft.AspNetCore.Mvc;
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


    }
}
