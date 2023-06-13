using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTO_s.Author;
using ServiceLayer.Services.Interfaces;

namespace App.Controllers
{
    public class AuthorController : AppController
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService service)
        {
            _authorService = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _authorService.GetAllAsync());
            }
            catch (Exception)
            {
                return NotFound("No records found!");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(AuthorCreateDto authorCreateDto)
        {
            try
            {
                await _authorService.CreateAsync(authorCreateDto);

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest(new { ErrorMessage = "Not Created" });
            }
        }
    }
}
