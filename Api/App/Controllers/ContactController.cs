using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTO_s.Contact;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.Validations.Contact;
using System.ComponentModel.DataAnnotations;

namespace App.Controllers
{
    public class ContactController : AppController
    {

        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }


        [HttpGet]
        public async Task<IActionResult> GetById([Required] int id)
        {
            try
            {
                return Ok(await _contactService.GetAsync(id));
            }
            catch (NullReferenceException)
            {
                return NotFound($"No records found. Id: {id}");
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _contactService.GetAllAsync());
            }
            catch (NullReferenceException)
            {
                return NotFound("No records found!");
            }
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ContactCreateDto contactCreateDto)
        {
            try
            {
                ContactCreateDtoValidator validator = new();

                var validationResult = validator.Validate(contactCreateDto);

                if (!validationResult.IsValid)
                {
                    return BadRequest(new { ErrorMessage = "Error! Please enter valid data." });
                }

                await _contactService.CreateAsync(contactCreateDto);

                return Ok();
            }
            catch (NullReferenceException)
            {
                return BadRequest(new { ErrorMessage = "Not Created" });
            }
        }


        [HttpPut, Route("{id}")]
        public async Task<IActionResult> Update([FromRoute][Required] int id, ContactUpdateDto contactUpdateDto)
        {
            ContactUpdateDtoValidator validator = new();
            var validationResult = validator.Validate(contactUpdateDto);

            if (!validationResult.IsValid)
            {
                return BadRequest(new { ErrorMessage = "Error! Please enter valid data." });
            }
            try
            {
                await _contactService.UpdateAsync(id, contactUpdateDto);

                return Ok();
            }
            catch (NullReferenceException)
            {
                return BadRequest(new { ErrorMessage = "Not Updated" });
            }
        }


        [HttpPost]
        public async Task<IActionResult> SoftDelete([Required] int id)
        {
            try
            {
                await _contactService.SoftDeleteAsync(id);

                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
