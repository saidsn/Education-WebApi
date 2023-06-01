using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTO_s.Contact;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.Validations.Contact;
using System.ComponentModel.DataAnnotations;

namespace App.Controllers
{
    public class ContactController : AppController
    {

        private readonly IContactService _service;

        public ContactController(IContactService service)
        {
            _service = service;
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

        [HttpPut, Route("{id}")]
        public async Task<IActionResult> Update([FromRoute][Required] int id, ContactUpdateDto contactUpdateDto)
        {
            try
            {
                await _service.UpdateAsync(id, contactUpdateDto);

                return Ok();
            }
            catch (NullReferenceException)
            {

                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage([FromBody] ContactCreateDto contactCreateDto)
        {
            ContactCreateDtoValidator validator = new();
            var validationResult = validator.Validate(contactCreateDto);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            try
            {
                await _service.CreateAsync(contactCreateDto);

                return Ok();
            }
            catch (Exception)
            {
                return new ObjectResult("Bir hata oluştu.") { StatusCode = 500 };
            }
        }
    }
}
