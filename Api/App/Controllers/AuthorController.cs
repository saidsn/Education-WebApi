using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTO_s.Author;
using ServiceLayer.Services.Interfaces;

namespace App.Controllers
{
    public class AuthorController : AppController
    {
        private readonly IAuthorService _service;

        public AuthorController(IAuthorService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create(AuthorCreateDto authorCreateDto)
        {
            try
            {
                await _service.CreateAsync(authorCreateDto);

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest(new { ErrorMessage = "Not Created" });
            }
        }

        //[HttpGet]
        //public async Task<IActionResult> GetAll()
        //{
        //    try
        //    {
        //        return Ok(await _service.GetAllAsync());
        //    }
        //    catch (NullReferenceException)
        //    {
        //        return NotFound();
        //    }
        //}
    }
}
