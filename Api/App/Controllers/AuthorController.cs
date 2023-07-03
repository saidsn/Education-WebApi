using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTO_s.Author;
using ServiceLayer.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace App.Controllers
{
    public class AuthorController : AppController
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }


        [HttpGet]
        public async Task<IActionResult> GetById([Required] int id)
        {
            try
            {
                return Ok(await _authorService.GetAsync(id));
            }
            catch (Exception)
            {
                return NotFound($"No records found. Id: {id}");
            }
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
        public async Task<IActionResult> Create([FromForm] AuthorCreateDto authorCreateDto)
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


        [HttpPut, Route("{id}")]
        public async Task<IActionResult> Update([Required][FromRoute] int id, [FromForm] AuthorUpdateDto authorUpdateDto)
        {
            try
            {
                await _authorService.UpdateAsync(id, authorUpdateDto);

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest(new { ErrorMessage = "Not Updated" });
            }
        }


        [HttpGet]
        public async Task<IActionResult> Search(string? search)
        {
            try
            {
                return Ok(await _authorService.SearchAsync(search));
            }
            catch (Exception)
            {
                return NotFound();
            }
        }



        [HttpDelete]
        public async Task<IActionResult> Delete([Required] int id)
        {
            try
            {
                await _authorService.DeleteAsync(id);

                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }


        [HttpPost]
        public async Task<IActionResult> SoftDelete([Required] int id)
        {
            try
            {
                await _authorService.SoftDeleteAsync(id);

                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
