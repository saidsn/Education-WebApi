using Microsoft.AspNetCore.Mvc;
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
            var result = await _service.GetAllAsync();

            return Ok(result);
        }



    }
}
