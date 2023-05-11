using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Interfaces;

namespace App.Controllers
{
    public class TitleController : AppController
    {
        private readonly ITitleService _titleService;
        private readonly IWebHostEnvironment _env;

        public TitleController(ITitleService titleService, IWebHostEnvironment env)
        {
            _titleService = titleService;
            _env = env;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _titleService.GetAllAsync();
            return Ok(result);
        }



    }
}
