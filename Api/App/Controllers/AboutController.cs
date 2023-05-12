using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace App.Controllers
{
    public class AboutController : AppController
    {
        private readonly IAboutService _service;
        private readonly IWebHostEnvironment _env;

        public AboutController(IAboutService service, IWebHostEnvironment env)
        {
            _service = service;
            _env = env;
        }

        [HttpGet]
        public async Task<IActionResult> Get([Required] int id)
        {
            try
            {
                var about = await _service.GetAsync(id);

                return Ok(about);
            }
            catch (NullReferenceException)
            {

                return NotFound();
            }
        }
    }
}
