using Microsoft.AspNetCore.Mvc;
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
                var banner = await _service.GetAsync(id);

                return Ok(banner);
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }
    }
}
